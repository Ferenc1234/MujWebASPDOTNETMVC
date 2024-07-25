using DevExpress.Xpo;


namespace MujWeb.Models
{
    public class Calculator : XPLiteObject
    {
        public Calculator(Session session) : base(session) { }

        int id;
        [Key(true)]
        public int Id

        {
            get { return GetPropertyValue<int>("Id"); }
            set { SetPropertyValue("Id", value); }
        }
    }
}

//[Key]
//[Required]
//public int Id { get; set; }

//[DisplayName("První číslo")]
//[StringToDouble(ErrorMessage = "Zadejte prosím validní číslo")]
//[Required(ErrorMessage = "Zadejte prosím hodnotu")]
//public required string FirstNumber { get; set; }
//[DisplayName("Druhé číslo")]
//[StringToDouble(ErrorMessage = "Zadejte prosím validní číslo")]
//[Required(ErrorMessage = "Zadejte prosím hodnotu")]
//public required string SecondNumber { get; set; }
//[DisplayName("Výsledek")]
//public double Result { get; set; }
//[Required(ErrorMessage = "Vyberte prosím operaci")]
//public required int Operation { get; set; } // 1 = +, 2 = -, 3 = *, 4 = /
