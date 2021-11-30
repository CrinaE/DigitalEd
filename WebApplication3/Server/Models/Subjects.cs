using System;
using System.Collections.Generic;

namespace WebApplication3.Server.Models
{
    public partial class Subjects
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
