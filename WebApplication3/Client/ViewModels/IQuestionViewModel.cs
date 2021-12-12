using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Shared.Models;

namespace WebApplication3.Client.ViewModels
{
    interface IQuestionViewModel
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string Title { get; set; }
        public int? Likes { get; set; }
        public string Contents { get; set; }
        public int? IdSubject { get; set; }
        public List<Question> Question { get; set; }
        public List<Question> YourQuestion { get; set; }

        public Task Add();
        public Task Load();
        public Task LoadaQeustion();
        public Task LoadYourQeustion();


    }
}
