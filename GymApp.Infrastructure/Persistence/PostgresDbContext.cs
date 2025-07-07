using Microsoft.EntityFrameworkCore;
using GymApp.Domain.Entities;

namespace GymApp.Infrastructure.Persistence
{
    public class PostgresDbContext : DbContext
    {
        public DbSet<Workout> Workouts => Set<Workout>();
        public DbSet<Exercise> Exercises => Set<Exercise>();

        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workout>().OwnsMany(w => w.Exercises, e =>
            {
                e.WithOwner();
                e.OwnsMany(ex => ex.Sets);
            });
        }
    }
}
