namespace BeerQuiz.Client.Model
{
    public class QuizItemResponse
    {
        public string Question { get; set; } = string.Empty;
        public IEnumerable<string> Options { get; set; } = Enumerable.Empty<string>();
        public int CorrectAnswerIndex { get; set; }
        public string GetAnswerString() => Options.ElementAt(CorrectAnswerIndex);
    }
}
