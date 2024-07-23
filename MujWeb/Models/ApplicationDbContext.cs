using Microsoft.EntityFrameworkCore;

namespace MujWeb.Models
{
    public class ApplicationDbContext : DbContext //Používá balíček na databáze
    {
        public DbSet<Uzivatel> Uzivatele { get; set; }  //Vytvoří tabulku Uzivatele

        public ApplicationDbContext(DbContextOptions options) : base(options) //Vrací nastavení databáze
        {
            
        }
    }
}
