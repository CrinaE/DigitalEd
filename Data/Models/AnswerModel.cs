namespace DigitalEdu.Data.Models
{
    public class AnswerModel
    {
        //IdAnswer PK
        public int IdAnswer { get; set;}
        
        //IdPerson FK -> PersonModel IdPerson
        public int IdPerson { get; set;}

        public int AnswerLike { get; set; }

        public string Answer { get; set; }
    }
}
