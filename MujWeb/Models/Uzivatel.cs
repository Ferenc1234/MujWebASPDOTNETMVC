using DevExpress.Xpo;


namespace MujWeb.Models
{
    public class Uzivatel : XPLiteObject
    {
        public Uzivatel(Session session) : base(session) { }

        int id;
        [Key(true)]
        public int Id

        {
            get { return GetPropertyValue<int>("Id"); }
            set { SetPropertyValue("Id", value); }
        }
        string? name;
        public string? Name
        {
            get { return GetPropertyValue<string>("name"); }
            set { SetPropertyValue("name", value); }
        }
        string? dateOfRegistration;
        public string? DateOfRegistration
        {
            get { return GetPropertyValue<string>("dateOfRegistration"); }
            set { SetPropertyValue("dateOfRegistration", value); }
        }
    }
}



//[DisplayName("Datum Registrace")]
//public DateTime DateOfRegistration { get; set; }