using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MujWeb.Models
{
    public class Uzivatel //Vytvoří třídu Uzivatel s atributy Id, Name a DateOfRegistration
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(15)]
        [DisplayName("Jméno")]
        public string Name { get; set; }
        [DisplayName("Datum Registrace")]
        public DateTime DateOfRegistration { get; set; }
    }
}
