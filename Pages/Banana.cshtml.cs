using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazerPagesMovie.Pages
{
    public class BananaModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public BananaModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}
