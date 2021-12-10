using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication3.Shared.Models
{
    public class Question
    {
        public Question()
        {
            Answers = new HashSet<Answers>();
        }

        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string Title { get; set; }
        public int? Likes { get; set; }
        public string Contents { get; set; }
        public int? IdSubject { get; set; }
        public virtual User IdUserNavigation { get; set; }
        public virtual Subjects IdSubjectNavigation { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
    }
}
