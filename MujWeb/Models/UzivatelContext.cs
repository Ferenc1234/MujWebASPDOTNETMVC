using Microsoft.EntityFrameworkCore;

namespace MujWeb.Models
{
    public class UzivatelContext : DbContext //Používá balíček na databáze
    {
        public DbSet<Uzivatel> Uzivatele { get; set; }  //Vytvoří tabulku Uzivatele

        public UzivatelContext(DbContextOptions options) : base(options) //Vrací nastavení databáze
        {
            
        }
    }
}
