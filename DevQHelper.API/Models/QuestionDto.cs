namespace DevQHelper.API.Models
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public int Technology { get; set; }
        public int Framework { get; set; }
        public int Difficulty { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
    }
}
