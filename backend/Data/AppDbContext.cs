using Microsoft.EntityFrameworkCore;
using Backend.Models; // 你的 Models 位置

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Prediction> Predictions { get; set; }

    }
}
