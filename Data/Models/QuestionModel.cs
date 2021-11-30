namespace DigitalEdu.Data.Models
{
    public class QuestionModel
    {
        //QuestionID pk
        public int QuestionId { get; set;}

        //IdPerson FK -> PersonModel.cs IdPerson
        public int IdPerson { get; set; }
        public string QuestionName { get; set;}
        public PersonModel PersonModel { get; set;}

        public int LikeQuestion { get; set;}

        public string Class { get; set;}
        
    }
}
