using BeerQuiz.Core.Entities;
using BeerQuiz.Core.Repositories;

namespace BeerQuiz.Infrastructure.Repositories;

public class QuizItemRepository : IQuizItemRepository
{
    private readonly BeerQuizDbContext _context;

    public QuizItemRepository(BeerQuizDbContext context)
    {
        _context = context;
    }

    public IEnumerable<IQuizItem> GetAll()
    {
        _context.Database.EnsureCreated();
        return _context.QuizItems!.ToList();
    }
}
