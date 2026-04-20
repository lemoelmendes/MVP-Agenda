using Microsoft.EntityFrameworkCore;
using MVP_Agenda.Models;

namespace MVP_Agenda.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
    }
}
