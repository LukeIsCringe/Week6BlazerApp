using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Week6BlazerApp.Data.Models;

namespace Week6BlazerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Module> Modules { get; set; }

        public DbSet<Programme> Programmes { get; set; }
    }
}
