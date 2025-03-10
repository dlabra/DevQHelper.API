using DevQHelper.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DevQHelper.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<QuestionDto> Questions { get; set; }
        public DbSet<RoleDto> Roles { get; set; }
        public DbSet<DifficultyDto> Difficulties { get; set; }
        public DbSet<FrameworkDto> Frameworks { get; set; }
        public DbSet<RoleDto> Technologies { get; set; }
        public DbSet<SideMenuDto> SideMenu { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
