using DBSpotifyAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DBSpotifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBSpotifyController : ControllerBase
    {
        private readonly SpotifyContext _context;

        public DBSpotifyController(SpotifyContext ctx)
        {
            _context = ctx; 
        }

        [HttpGet("GetSongs")]
        public async Task<IActionResult> GetSongs()
        {
            try
            {
                var songs = await _context.Songs.ToListAsync();
                return Ok(songs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetGenres")]
        public async Task<IActionResult> GetGenres()
        {
            try
            {
                var songs = await _context.Genres.ToListAsync();
                return Ok(songs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetArtists")]
        public async Task<IActionResult> GetArtists()
        {
            try
            {
                var artists = await _context.Artists.ToListAsync();
                return Ok(artists);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAlbums")]
        public async Task<IActionResult> GetAlbums()
        {
            try
            {
                var albums = await _context.Albums.ToListAsync();
                return Ok(albums);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetPlaylists")]
        public async Task<IActionResult> GetPlaylists()
        {
            try
            {
                var playlists = await _context.Playlists.ToListAsync();
                return Ok(playlists);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetPlaylistSongs")]
        public async Task<IActionResult> GetPlaylistSongs()
        {
            try
            {
                var playlistsongs = await _context.PlaylistSongs.ToListAsync();
                return Ok(playlistsongs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetRadios")]
        public async Task<IActionResult> GetRadios()
        {
            try
            {
                var radios = await _context.Radios.ToListAsync();
                return Ok(radios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAccount")]

        public async Task<IActionResult> GetAccount()
        {
            try
            {
                var account = await _context.Accounts.ToListAsync();
                return Ok(account);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
