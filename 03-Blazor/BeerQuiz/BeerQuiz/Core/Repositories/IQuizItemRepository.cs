using BeerQuiz.Core.Entities;

namespace BeerQuiz.Core.Repositories;

public interface IQuizItemRepository
{
    IEnumerable<IQuizItem> GetAll();
}
