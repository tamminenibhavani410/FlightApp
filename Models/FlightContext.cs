using Microsoft.EntityFrameworkCore;

namespace Flight.Models
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options)
            : base(options)
        { }
        public DbSet<FlightModel> FlightModel { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightModel>().HasData(
                new FlightModel
                {
                    FlightModelId = 1,
                    FlightNumber = "UA3321",
                    From = "Chicago",
                    To = "New York",
                    Date = "2/15/2026",
                    Price = 235
                },
                new FlightModel
                {
                    FlightModelId = 2,
                    FlightNumber = "QA1078",
                    From = "Dubai",
                    To = "London",
                    Date = "3/1/2026",
                    Price = 590
                },
                new FlightModel
                {
                    FlightModelId = 3,
                    FlightNumber = "UA3321",
                    From = "Hong Kong",
                    To = "San Francisco",
                    Date = "6/15/2026",
                    Price = 900
                }
            );
        }
    }
}
