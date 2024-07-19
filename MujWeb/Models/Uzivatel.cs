using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MujWeb.Models
{
    public class Uzivatel //Vytvoří třídu Uzivatel s atributy Id, Name a DateOfRegistration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Jméno")]
        public int Name { get; set; }
        [Required]
        [DisplayName("Datum Registrace")]
        public string DateOfRegistration { get; set; }
    }
}
