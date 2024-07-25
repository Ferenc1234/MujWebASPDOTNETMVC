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
        string? firstNumber;
        public string? FirstNumber
        {
            get { return GetPropertyValue<string>("firstNumber"); }
            set { SetPropertyValue("firstNumber", value); }
        }
        string? secondNumber;
        public string? SecondNumber
        {
            get { return GetPropertyValue<string>("secondNumber"); }
            set { SetPropertyValue("secondNumber", value); }
        }
        string? operation;
        public int Operation
        {
            get { return GetPropertyValue<int>("operation"); }
            set { SetPropertyValue("operation", value); }
        }
        string? result;
        public double Result
        {
            get { return GetPropertyValue<double>("result"); }
            set { SetPropertyValue("result", value); }
        }
    }
}