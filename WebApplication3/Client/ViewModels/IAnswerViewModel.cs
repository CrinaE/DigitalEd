using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Shared.Models;

namespace WebApplication3.Client.ViewModels
{
    interface IAnswerViewModel
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int? Likes { get; set; }
        public string Contents { get; set; }
        public int? IdQuestion { get; set; }
        public List<Answers> Answers { get; set; }

        public Task Add();
        public Task Load();
        public Task LoadYourAnswers();
    }
}
