using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication3.Shared.Models;

namespace WebApplication3.Client.ViewModels
{
    public class AnswerViewModel : IAnswerViewModel
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int? Likes { get; set; }
        public string Contents { get; set; }
        public int? IdQuestion { get; set; }
        public List<Answers> Answers { get; set; }

        private HttpClient _httpClient;

        public AnswerViewModel()
        {

        }

        public AnswerViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Add()
        {
            Answers answer = this;
            await _httpClient.PutAsJsonAsync("answers/newanswer/", answer);
        }

        public async Task Load()
        {
            this.Answers = await _httpClient.GetFromJsonAsync<List<Answers>>("answers/"+this.IdQuestion);
        }

        public async Task LoadYourAnswers()
        {
            this.Answers = await _httpClient.GetFromJsonAsync<List<Answers>>("answers/getyouranswers/");
        }

        public static implicit operator Answers(AnswerViewModel answerViewModel)
        {
            return new Answers
            {
                Id = answerViewModel.Id,
                IdUser = answerViewModel.IdUser,
                Likes = answerViewModel.Likes,
                Contents = answerViewModel.Contents,
                IdQuestion = answerViewModel.IdQuestion
            };
        }

        public static implicit operator AnswerViewModel(Answers answer)
        {
            return new AnswerViewModel
            {
                Id = answer.Id,
                IdUser = answer.IdUser,
                Likes = answer.Likes,
                Contents = answer.Contents,
                IdQuestion = answer.IdQuestion
            };
        }
    }
}
