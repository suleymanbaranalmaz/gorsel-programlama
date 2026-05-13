using System;
using System.Collections.Generic;

namespace ATOTIFY.Modeller
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Gerçek üyelik için eklendi
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<PlayHistory> PlayHistories { get; set; }
    }
}
