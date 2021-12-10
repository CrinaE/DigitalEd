using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication3.Shared.Models
{
    public class User
    {
        public User()
        {
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public int? Points { get; set; }
        public string ProfilePic { get; set; }

        public Answers Answers { get; set; }
        public virtual ICollection<Question> Question { get; set; }
    }
}
