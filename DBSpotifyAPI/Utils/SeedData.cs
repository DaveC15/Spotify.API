using DBSpotifyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSpotifyAPI.Utils
{
    public static class SeedData
    {
        public static async Task SeedDataBase(SpotifyContext ctx)
        {
            Clear(ctx.Albums);
            Clear(ctx.Songs);
            Clear(ctx.Artists);
            Clear(ctx.Playlists);
            Clear(ctx.PlaylistSongs);
            Clear(ctx.Radios);
            Clear(ctx.Genres);

            Account account = new() { Id = 1, UserName = "admin", Playlists = new() };

            List<Artist> artists = new List<Artist>() 
            { 
                new Artist() {Title = "Cannibal Corpe", Albums = new(), Songs = new(), Id = 1 },
                new Artist() {Title = "Aerosmith", Albums = new(), Songs = new(), Id = 2 },
                new Artist() {Title = "Nickelback", Albums = new(), Songs = new(), Id = 3 },
                new Artist() {Title = "Pino Daniele", Albums = new(), Songs = new(), Id = 4 },
                new Artist() {Title = "Metallica", Albums = new(), Songs = new(), Id = 5 },
                new Artist() {Title = "AC DC", Albums = new(), Songs = new(), Id = 6 }
            };

            List<Album> albums = new List<Album>()
            {
                new Album() {Title = "Kill", Songs = new(), ArtistId = 1, GenreId = 1, Id =1  },
                new Album() {Title = "Best Of", Songs = new(), ArtistId = 2, GenreId = 1, Id =2 },
                new Album() {Title = "Get Rollin",Songs = new(), ArtistId = 3, GenreId = 2, Id =3 },
                new Album() {Title = "Medina", Songs = new(), ArtistId = 4, GenreId = 3, Id =4 },
                new Album() {Title = "Metallica", Songs = new() , ArtistId = 5, GenreId = 2, Id =5},
                new Album() {Title = "Back in Black", Songs = new(), ArtistId = 6, GenreId = 1, Id =6 }
            };

            List<Song> songs = new List<Song>()
            {
                new Song() {Title = "The Time to Kill is Now", Id= 1, AlbumId = 1, ArtistId = 1, GenreId = 1, Popularity = 10},
                new Song() {Title = "Murder Worship", Id= 2, AlbumId = 1, ArtistId = 1, GenreId = 1, Popularity = 20},
                new Song() {Title = "Death Waking Terror", Id= 3, AlbumId = 1, ArtistId = 1, GenreId = 1, Popularity = 30},
                new Song() {Title = "Make Them Suffer", Id= 4, AlbumId = 1, ArtistId = 1, GenreId = 1, Popularity = 40},
                new Song() {Title = "Purification by fire", Id= 5, AlbumId = 1, ArtistId = 1, GenreId = 1, Popularity = 10},
                new Song() {Title = "Barbaric", Id= 6, AlbumId = 1, ArtistId = 1, GenreId = 1, Popularity = 20},

                new Song() {Title = "Angel", Id= 7, AlbumId = 2, ArtistId = 2, GenreId = 1, Popularity = 10},
                new Song() {Title = "Crazy", Id= 8, AlbumId = 2, ArtistId = 2, GenreId = 1, Popularity = 20},
                new Song() {Title = "Cryin", Id= 9, AlbumId = 2, ArtistId = 2, GenreId = 1, Popularity = 30},
                new Song() {Title = "Dream On", Id= 10, AlbumId = 2, ArtistId = 2, GenreId = 1, Popularity = 10},
                new Song() {Title = "Walk this Way", Id= 11, AlbumId = 2, ArtistId = 2, GenreId = 1, Popularity = 40},
                new Song() {Title = "Rag Doll", Id= 12, AlbumId = 2, ArtistId = 2, GenreId = 1, Popularity = 10},

                new Song() {Title = "San Quentin", Id= 13, AlbumId = 3, ArtistId = 3, GenreId = 2, Popularity = 10},
                new Song() {Title = "Skinny Little Missy", Id= 14, AlbumId = 3, ArtistId = 3, GenreId = 2, Popularity = 30},
                new Song() {Title = "Those Days", Id= 15, AlbumId = 3, ArtistId = 3, GenreId = 2, Popularity = 20},
                new Song() {Title = "High Time", Id= 16, AlbumId = 3, ArtistId = 3, GenreId = 2, Popularity = 40},
                new Song() {Title = "Vegans Bomb", Id= 17, AlbumId = 3, ArtistId = 3, GenreId = 2, Popularity = 10},
                new Song() {Title = "Tidal Wave", Id= 18, AlbumId = 3, ArtistId = 3, GenreId = 2, Popularity = 10},

                new Song() {Title = "Via Medina", Id= 19, AlbumId = 4, ArtistId = 4, GenreId = 3, Popularity = 10},
                new Song() {Title = "Evviva o rre", Id= 20, AlbumId = 4, ArtistId = 4, GenreId = 3, Popularity = 10},
                new Song() {Title = "Tempo di cambiare", Id= 21, AlbumId = 4, ArtistId = 4, GenreId = 3, Popularity = 30},
                new Song() {Title = "Sara", Id= 22, AlbumId = 4, ArtistId = 4, GenreId = 3, Popularity = 40},
                new Song() {Title = "Senza di te", Id= 23, AlbumId = 4, ArtistId = 4, GenreId = 3, Popularity = 20},
                new Song() {Title = "Mareluna", Id= 24, AlbumId = 4, ArtistId = 4, GenreId = 3, Popularity = 20},

                new Song() {Title = "Enter Sandman", Id= 25, AlbumId = 5, ArtistId = 5, GenreId = 2, Popularity = 20},
                new Song() {Title = "Sad but true", Id= 26, AlbumId = 5, ArtistId = 5, GenreId = 2, Popularity = 10},
                new Song() {Title = "Holler then thou", Id= 27, AlbumId = 5, ArtistId = 5, GenreId = 2, Popularity = 30},
                new Song() {Title = "Nothing else matter", Id= 28, AlbumId = 5, ArtistId = 5, GenreId = 2, Popularity = 40},
                new Song() {Title = "Wherever i may roam", Id= 29, AlbumId = 5, ArtistId = 5, GenreId = 2, Popularity = 10},
                new Song() {Title = "The Unforgiven", Id= 30, AlbumId = 5, ArtistId = 5, GenreId = 2, Popularity = 20},

                new Song() {Title = "Hells Bells", Id= 31, AlbumId = 6, ArtistId = 6, GenreId = 1, Popularity = 20},
                new Song() {Title = "Shoot to thrill", Id= 32, AlbumId = 6, ArtistId = 6, GenreId = 1, Popularity = 10},
                new Song() {Title = "Bck in Black", Id= 36, AlbumId = 6, ArtistId = 6, GenreId = 1, Popularity = 40},
                new Song() {Title = "Shake a leg", Id= 38, AlbumId = 6, ArtistId = 6, GenreId = 1, Popularity = 50},
                new Song() {Title = "Have a drink on me", Id= 39, AlbumId = 6, ArtistId = 6, GenreId = 1, Popularity = 10},
                new Song() {Title = "Let me put my love into you", Id= 40, AlbumId = 6, ArtistId = 6, GenreId = 1, Popularity = 20},
            };

            List<Playlist> playlists = new List<Playlist>()
            {
                new Playlist() {Id = 1, Title="Bellissimo", AccountId= 1},
                new Playlist() {Id = 2, Title="Top", AccountId= 1}
            };

            List<Genre> genres = new List<Genre>()
            { 
                new Genre() {Id = 1,Title = "HardRock", Albums = new(), Radios = new(), Songs= new()},
                new Genre() {Id = 2, Title = "Rock", Albums = new(), Radios = new(), Songs= new()},
                new Genre() {Id = 3, Title = "Pop", Albums = new(), Radios = new(), Songs= new()},
                new Genre() {Id = 4,Title = "Metal", Albums = new(), Radios = new(), Songs= new()}
            };

            List<Radio> radios = new List<Radio>()
            {
                new Radio() {Id = 1,Title="HardRock2022", GenreId = 1},
                new Radio() {Id = 2,Title="Rock2022", GenreId = 2},
                new Radio() {Id = 3,Title="Pop2022", GenreId = 3},
                new Radio() {Id = 4,Title="Metal2022", GenreId = 4}
            };

            List<PlaylistSong> songList = new List<PlaylistSong>()
            { 
                new PlaylistSong() {Id = 1, SongId=1, PlaylistId=1},
                new PlaylistSong() {Id = 2, SongId=2, PlaylistId=1},
                new PlaylistSong() {Id = 3, SongId=5, PlaylistId=2},
                new PlaylistSong() {Id = 4, SongId=10, PlaylistId=2}
            };
        }

        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            if (dbSet.Any())
                dbSet.RemoveRange(dbSet.ToList());

        }
    }
}
