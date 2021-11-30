using System;
using System.Collections.Generic;

namespace WebApplication3.Server.Models
{
    public partial class Answers
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int? Likes { get; set; }
        public string Contents { get; set; }
        public int? IdQuestion { get; set; }

        public virtual Question IdQuestionNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
