namespace DigitalEdu.Data.Models
{
    public class PersonModel
    {
        //ID PK
        public int IdPerson { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }
       
        public string Password { get; set; }

        public string Token { get; set; }

        public int Points { get; set; }
    }
}
