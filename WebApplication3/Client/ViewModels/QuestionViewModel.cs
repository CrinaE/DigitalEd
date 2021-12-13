using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication3.Shared.Models;

namespace WebApplication3.Client.ViewModels
{
    public class QuestionViewModel : IQuestionViewModel
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string Title { get; set; }
        public int? Likes { get; set; }
        public string Contents { get; set; }
        public string Picture { get; set; }
        public int? IdSubject { get; set; }
        public List<Question> Question { get; set; }
        public List<Question> YourQuestion { get; set; }
        public List<Subjects> Subjects { get; set; }
        public string Message { get; set; }
        public Subjects Subject { get; set; }


        public HttpClient _httpClient;
        public QuestionViewModel()
        {

        }
        public QuestionViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Add()
        {
            Question question = this;
            await _httpClient.PutAsJsonAsync("question/newquestion/", question);
        }

        public async Task Load()
        {
           this.Question = await _httpClient.GetFromJsonAsync<List<Question>>("question/");

        }

        private void LoadCurrentObject(QuestionViewModel questionViewModel)
        {
            this.Title = questionViewModel.Title;
            this.Contents = questionViewModel.Contents;
            this.Picture = questionViewModel.Picture;
            this.Likes = questionViewModel.Likes;
        }

        public async Task LoadaQeustion()
        {
            Question question = await _httpClient.GetFromJsonAsync<Question>("question/getquestion/" + this.Id);
            LoadCurrentObject(question);
        }

        public async Task LoadYourQeustion()
        {
            this.YourQuestion = await _httpClient.GetFromJsonAsync<List<Question>>("question/getyourquestion/");
        }

        public async Task LoadSubjects()
        {
           this.Subjects = await _httpClient.GetFromJsonAsync<List<Subjects>>("question/getsubjects/");
        }

        public void OnChange()
        {
            this.IdSubject = this.Subject.Id;
        }

        public static implicit operator Question(QuestionViewModel questionViewModel)
        {
            return new Question
            {
                Id = questionViewModel.Id,
                IdUser = questionViewModel.IdUser,
                Title = questionViewModel.Title,
                Likes = questionViewModel.Likes,
                Contents = questionViewModel.Contents,
                IdSubject = questionViewModel.IdSubject,
                Picture = questionViewModel.Picture
            };
        }

        public static implicit operator QuestionViewModel(Question question)
        {
            return new QuestionViewModel
            {
                Id = question.Id,
                IdUser = question.IdUser,
                Title = question.Title,
                Likes = question.Likes,
                Contents = question.Contents,
                IdSubject = question.IdSubject,
                Picture = question.Picture
            };
        }
    }
}
