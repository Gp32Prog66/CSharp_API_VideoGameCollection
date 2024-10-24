using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageVideoGameCollection.Pages;

public class UpdateGamesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public UpdateGamesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
