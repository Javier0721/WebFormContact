using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options) { }


    public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}
