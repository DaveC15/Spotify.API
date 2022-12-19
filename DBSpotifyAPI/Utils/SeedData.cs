using DBSpotifyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

            Account account = new() {UserName = "admin", Playlists = new(), Email="d", Pw="g", SubscriptionName="r" };

            List<Artist> artists = new List<Artist>() 
            { 
                new Artist() {Title = "Cannibal Corpe", Albums = new(), Songs = new()},
                new Artist() {Title = "Aerosmith", Albums = new(), Songs = new()},
                new Artist() {Title = "Nickelback", Albums = new(), Songs = new() },
                new Artist() {Title = "Pino Daniele", Albums = new(), Songs = new() },
                new Artist() {Title = "Metallica", Albums = new(), Songs = new() },
                new Artist() {Title = "AC DC", Albums = new(), Songs = new() }
            };

            List<Album> albums = new List<Album>()
            {
                new Album() {Title = "Kill", Songs = new()},
                new Album() {Title = "Best Of", Songs = new()},
                new Album() {Title = "Get Rollin",Songs = new()},
                new Album() {Title = "Medina", Songs = new() },
                new Album() {Title = "Metallica", Songs = new()},
                new Album() {Title = "Back in Black", Songs = new()}
            };

            List<Song> songs = new List<Song>()
            {
                new Song() {Title = "The Time to Kill is Now",Popularity = 10},
                new Song() {Title = "Murder Worship", Popularity = 20},
                new Song() {Title = "Death Waking Terror", Popularity = 30},
                new Song() {Title = "Make Them Suffer", Popularity = 40},
                new Song() {Title = "Purification by fire", Popularity = 10},
                new Song() {Title = "Barbaric", Popularity = 20},

                new Song() {Title = "Angel", Popularity = 10},
                new Song() {Title = "Crazy", Popularity = 20},
                new Song() {Title = "Cryin", Popularity = 30},
                new Song() {Title = "Dream On", Popularity = 10},
                new Song() {Title = "Walk this Way", Popularity = 40},
                new Song() {Title = "Rag Doll", Popularity = 10},

                new Song() {Title = "San Quentin", Popularity = 10},
                new Song() {Title = "Skinny Little Missy", Popularity = 30},
                new Song() {Title = "Those Days", Popularity = 20},
                new Song() {Title = "High Time", Popularity = 40},
                new Song() {Title = "Vegans Bomb", Popularity = 10},
                new Song() {Title = "Tidal Wave", Popularity = 10},

                new Song() {Title = "Via Medina", Popularity = 10},
                new Song() {Title = "Evviva o rre", Popularity = 10},
                new Song() {Title = "Tempo di cambiare", Popularity = 30},
                new Song() {Title = "Sara", Popularity = 40},
                new Song() {Title = "Senza di te", Popularity = 20},
                new Song() {Title = "Mareluna", Popularity = 20},

                new Song() {Title = "Enter Sandman", Popularity = 20},
                new Song() {Title = "Sad but true", Popularity = 10},
                new Song() {Title = "Holler then thou", Popularity = 30},
                new Song() {Title = "Nothing else matter", Popularity = 40},
                new Song() {Title = "Wherever i may roam", Popularity = 10},
                new Song() {Title = "The Unforgiven", Popularity = 20},

                new Song() {Title = "Hells Bells", Popularity = 20},
                new Song() {Title = "Shoot to thrill", Popularity = 10},
                new Song() {Title = "Bck in Black", Popularity = 40},
                new Song() {Title = "Shake a leg", Popularity = 50},
                new Song() {Title = "Have a drink on me", Popularity = 10},
                new Song() {Title = "Let me put my love into you", Popularity = 20},
            };

            List<Playlist> playlists = new List<Playlist>()
            {
                new Playlist() { Title="Bellissimo"},
                new Playlist() { Title="Top"}
            };

            List<Genre> genres = new List<Genre>()
            { 
                new Genre() {Title = "HardRock", Albums = new(), Radios = new(), Songs= new()},
                new Genre() { Title = "Rock", Albums = new(), Radios = new(), Songs= new()},
                new Genre() {Title = "Pop", Albums = new(), Radios = new(), Songs= new()},
                new Genre() {Title = "Metal", Albums = new(), Radios = new(), Songs= new()}
            };

            List<Radio> radios = new List<Radio>()
            {
                new Radio() {Title="HardRock2022"},
                new Radio() {Title="Rock2022"},
                new Radio() {Title="Pop2022"},
                new Radio() {Title="Metal2022" }
            };

            /*List<PlaylistSong> songList = new List<PlaylistSong>()
            { 
                new PlaylistSong() {Id = 1, SongId=1, PlaylistId=1},
                new PlaylistSong() {Id = 2, SongId=2, PlaylistId=1},
                new PlaylistSong() {Id = 3, SongId=5, PlaylistId=2},
                new PlaylistSong() {Id = 4, SongId=10, PlaylistId=2}
            };*/

            for (int i = 0; i<artists.Count; i++)
            {
                artists[i].Albums.Add(albums[i]);
            }
            for (int i = 0; i < artists.Count; i++)
            {
                artists[i].Songs.AddRange(GetPage<Song>(songs, i, 6));
            }
            for (int i = 0; i < albums.Count; i++)
            {
                albums[i].Songs.AddRange(GetPage<Song>(songs,i,6));
            }
            for (int i = 0; i < radios.Count; i++)
            {
                radios[i].Genre = genres[i];
            }

            var temp = new List<Song>();
            for (int i = 0; i < genres.Count; i++)
            {
                temp = new List<Song>() { songs[i*6], songs[i*6 + 1], songs[i*6 + 2], songs[i*6 + 3], songs[i*6 + 4], songs[i*6 + 5] };
                genres[i].Songs.AddRange(temp);
            }
            temp = new List<Song>() { songs[24], songs[25], songs[26], songs[27], songs[28], songs[29] };
            genres[0].Songs.AddRange(temp);
            temp = new List<Song>() { songs[30], songs[31], songs[32], songs[33], songs[34], songs[35] };
            genres[1].Songs.AddRange(temp);



            account.Playlists = playlists;

            ctx.Artists.AddRange(artists);
            ctx.Albums.AddRange(albums);
            ctx.Songs.AddRange(songs);
            ctx.Radios.AddRange(radios);
            ctx.Playlists.AddRange(playlists);
            ctx.Genres.AddRange(genres);
            ctx.Accounts.Add(account);
            try
            {
                await ctx.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
                System.Console.WriteLine(ex.Message);
            }
        }

        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            if (dbSet.Any())
                dbSet.RemoveRange(dbSet.ToList());
        }
        public static IList<T> GetPage<T>(IList<T> list, int page, int pageSize)
        {
            return list.Skip(page * pageSize).Take(pageSize).ToList();
        }
    }
}
