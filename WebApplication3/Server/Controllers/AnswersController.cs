using Microsoft.AspNetCore.Mvc;
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
    public class AnswersController : ControllerBase
    {
        private readonly ILogger<AnswersController> logger;
        private readonly DigitalEduContext _context;

        public AnswersController(ILogger<AnswersController> logger, DigitalEduContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        // GET: api/<AnswersController>
        [HttpGet("{questionId}")]
        public List<Answers> Get(int questionId)
        {
            return _context.Answers.Where(q => q.IdQuestion == questionId).ToList();

        }

        // POST api/<AnswersController>
        [HttpPut("newanswer")]
        public async Task<ActionResult<Answers>> NewQuestion(Answers answer)
        {
            Answers newAnswer = new Answers();
            newAnswer.Id = _context.Answers.Max(Answer => Answer.Id) + 1;
            newAnswer.IdUser = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            newAnswer.Likes = 0;
            newAnswer.Contents = answer.Contents;
            newAnswer.IdQuestion = answer.IdQuestion;
            _context.Answers.Add(newAnswer);
            await _context.SaveChangesAsync();
            return await Task.FromResult(newAnswer);
        }

        // PUT api/<AnswersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnswersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
