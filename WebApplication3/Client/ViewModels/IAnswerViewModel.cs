using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Client.ViewModels
{
    interface IAnswerViewModel
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int? Likes { get; set; }
        public string Contents { get; set; }
        public int? IdQuestion { get; set; }
        public Task Add();
        public Task Load();
    }
}
