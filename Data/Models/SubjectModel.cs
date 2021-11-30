namespace DigitalEdu.Data.Models
{
    public class SubjectModel
    {
        //IdClass PK
        public int IdClass { get; set; }

        //IdFaculty FK -> FacultyModel.cs IdFaculty
        public int IdFaculty { get; set; }
        public string SubjectName { get; set; }

        public int Year  { get; set; }
    }
}
