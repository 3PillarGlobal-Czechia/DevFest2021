using BeerQuiz.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace BeerQuiz.Infrastructure.Entities
{
    public class QuizItem : IQuizItem
    {
        [Key]
        [Required]
        [MaxLength(500)]
        public string Question { get; set; } = string.Empty;

        [Required]
        public IEnumerable<string> Options { get; set; } = Enumerable.Empty<string>();
        
        [Required]
        public int CorrectAnswerIndex { get; set; }

        public string GetAnswerString() => Options.ElementAt(CorrectAnswerIndex);
    }
}
