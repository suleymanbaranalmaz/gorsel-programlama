using System;
using System.Collections.Generic;

namespace ATOTIFY.Modeller
{
    public class Playlist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public ICollection<PlaylistSong> PlaylistSongs { get; set; }
    }

    public class PlaylistSong
    {
        public int PlaylistId { get; set; }
        public int SongId { get; set; }
        public DateTime AddedAt { get; set; }
        public int OrderIndex { get; set; }

        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }
}
