using ContactsControl.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsControl.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)  : base(options)
        { 
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
