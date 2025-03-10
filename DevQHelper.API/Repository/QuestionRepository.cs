using DevQHelper.API.Data;
using DevQHelper.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DevQHelper.API.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly AppDbContext _context;

        public QuestionRepository(AppDbContext context)
        {
            _context = context; 
        }
        public async Task AddQuestionAsync(QuestionDto question)
        {
            await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();
        }

        public async Task<QuestionDto> GetQuestionsByIdAsync(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            return question;
        }

        public async Task<IEnumerable<QuestionDto>> GetQuestionsBySectionAsync(int idTech, int idFramework, int idDifficulty)
        {
            var questions = await _context.Questions.Where(x => x.Technology == idTech && x.Framework == idFramework && x.Difficulty == idDifficulty).ToListAsync();
            return questions;
        }
    }
}
