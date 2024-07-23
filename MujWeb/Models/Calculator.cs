using MujWeb.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MujWeb.Models
{
    public class Calculator
    {
        [DisplayName("První číslo")]
        [StringToDouble(ErrorMessage = "Zadejte prosím validní číslo")]
        [Required(ErrorMessage = "Zadejte prosím hodnotu")]
        public required string FirstNumber { get; set; }
        [DisplayName("Druhé číslo")]
        [StringToDouble(ErrorMessage = "Zadejte prosím validní číslo")]
        [Required(ErrorMessage = "Zadejte prosím hodnotu")]
        public required string SecondNumber { get; set; }
        [DisplayName("Výsledek")]
        public double Result { get; set; }
        [Required(ErrorMessage = "Vyberte prosím operaci")]
        public required int Operation { get; set; } // 1 = +, 2 = -, 3 = *, 4 = /
    }
}
