using BeerQuiz.Core.Entities;
using BeerQuiz.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BeerQuiz.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : Controller
{
    private readonly IQuizItemRepository _itemRepository;

    public QuestionController(IQuizItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    [HttpGet]
    public IEnumerable<IQuizItem> GetAll()
    {
        return _itemRepository.GetAll();
    }
}
