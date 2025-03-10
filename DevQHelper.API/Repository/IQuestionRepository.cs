using DevQHelper.API.Models;

namespace DevQHelper.API.Repository
{
    public interface IQuestionRepository
    {
        Task AddQuestionAsync(QuestionDto question);
        Task<QuestionDto> GetQuestionsByIdAsync(int id);
        Task<IEnumerable<QuestionDto>> GetQuestionsBySectionAsync(int idTech, int idFramework, int idDifficulty);
    }
}
