using ContactsListApp.Models;
using Microsoft.EntityFrameworkCore;
// klasa wymagana do połaczenia z bazą danych
namespace ContactsListApp.Data
{
    public class ContactApiDbContext : DbContext
    {
        public ContactApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
