namespace ATOTIFY.Modeller
{
    public class Song
    {
        public int Id { get; set; }
        public string ExternalId { get; set; } // YouTube ID or Spotify ID
        public string YoutubeId { get; set; } // Explicit YouTube Video ID for exact match
        public string SourceType { get; set; } // "YouTube" or "Spotify"
        public string Title { get; set; }
        public string Artist { get; set; }
        public int DurationSeconds { get; set; }
        public string CoverUrl { get; set; }
        
        public System.Collections.Generic.ICollection<PlayHistory> PlayHistories { get; set; }
    }
}
