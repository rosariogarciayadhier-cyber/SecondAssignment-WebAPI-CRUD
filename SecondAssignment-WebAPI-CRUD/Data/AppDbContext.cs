using Microsoft.EntityFrameworkCore;
using SecondAssignment_WebAPI_CRUD.Models;

namespace SecondAssignment_WebAPI_CRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
