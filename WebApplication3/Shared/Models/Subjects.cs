using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication3.Shared.Models
{
    public class Subjects
    {
        public Subjects()
        {
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Subject { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}
