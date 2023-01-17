using Microsoft.EntityFrameworkCore;
using Project.Models.Domain;

namespace Project.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts{ get; set; }
    }
}
