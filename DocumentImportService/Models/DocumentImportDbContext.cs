using Microsoft.EntityFrameworkCore;

namespace DocumentImportService.Models
{
    public class DocumentImportDbContext : DbContext
    {
        public DocumentImportDbContext(DbContextOptions<DocumentImportDbContext> options) : base(options) { }

        public DbSet<Demo> Demos { get; set; }
    }
}
