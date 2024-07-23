using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MujWeb.Models
{
    public class Calculator
    {
        [DisplayName("První číslo")]
        [Required]
        public required string FirstNumber { get; set; }
        [Required]
        [DisplayName("Druhé číslo")]
        public required string SecondNumber { get; set; }
        [DisplayName("Výsledek")]
        public double Result { get; set; }
        public int Operation { get; set; } // 1 = +, 2 = -, 3 = *, 4 = /
    }
}
