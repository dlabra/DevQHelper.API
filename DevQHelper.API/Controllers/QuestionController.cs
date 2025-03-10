using DevQHelper.API.Models;
using DevQHelper.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DevQHelper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestionAsync(QuestionDto question)
        {
            if (question == null)
                return BadRequest();

            await _questionRepository.AddQuestionAsync(question);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<QuestionDto>>> GetQuestionsBySection(
            [FromQuery] int idTech, [FromQuery] int idFramework, [FromQuery] int idDifficulty)
        {
            var questions = await _questionRepository.GetQuestionsBySectionAsync(idTech, idFramework, idDifficulty);
            return Ok(questions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<QuestionDto>>> GetQuestionsById(int id)
        {
            var question = await _questionRepository.GetQuestionsByIdAsync(id);
            return Ok(question);
        }
    }
}
