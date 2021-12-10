using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication3.Server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly ILogger<QuestionController> logger;
        private readonly DigitalEduContext _context;
        // GET: api/<QuestionController>

        public QuestionController(ILogger<QuestionController> logger, DigitalEduContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        [HttpGet]
        public List<Question> Get()
        {
            return _context.Question.ToList();

        }

        // GET api/<QuestionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("getquestion/{questionId}")]
        public async Task<Question> GetProfile(int questionId)
        {
            return await _context.Question.Where(q => q.Id == questionId).FirstOrDefaultAsync();
        }

        // PUT api/<QuestionController>/5
        [HttpPut("newquestion")]
        public async Task<ActionResult<Question>> NewQuestion(Question question)
        {
            Question newQuestion = new Question();
            newQuestion.Id = _context.Question.Max(question => question.Id) + 1;
            newQuestion.IdSubject = 1;
            newQuestion.IdUser = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            newQuestion.Title = question.Title;
            newQuestion.Likes = 0;
            newQuestion.Contents = question.Contents;
            _context.Question.Add(newQuestion);
            await _context.SaveChangesAsync();
            return await Task.FromResult(newQuestion);
        }

        // DELETE api/<QuestionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
