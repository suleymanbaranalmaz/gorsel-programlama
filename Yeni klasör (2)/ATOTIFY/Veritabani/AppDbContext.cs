using Microsoft.EntityFrameworkCore;
using ATOTIFY.Modeller;
using System;

namespace ATOTIFY.Veritabani
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistSong> PlaylistSongs { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PlayHistory> PlayHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Bilgisayarında SQLEXPRESS kurulu olduğu için bağlantıyı oraya yönlendiriyoruz
                string connectionString = @"Server=.\SQLEXPRESS;Database=AtotifyDB;Trusted_Connection=True;MultipleActiveResultSets=true;";
                
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistSong>()
                .HasKey(ps => new { ps.PlaylistId, ps.SongId });
        }
    }
}
