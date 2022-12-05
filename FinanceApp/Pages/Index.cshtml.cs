using FinanceApp.Models;
using FinanceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinanceApp.Pages
{
    public class IndexModel : PageModel
    {
        public FinanceNews news;
        private readonly ILogger<IndexModel> _logger;
        private readonly INewsService _newsService;

        public IndexModel(ILogger<IndexModel> logger, INewsService newService)
        {
            _logger = logger;
            _newsService = newService;
        }

        public void OnGet()
        {
            news = _newsService.GetFinanceNews(0);
        }

        public void OnGetLoadMoreNews(int offset)
        {
            news = _newsService.GetFinanceNews(offset);
        }
    }
}