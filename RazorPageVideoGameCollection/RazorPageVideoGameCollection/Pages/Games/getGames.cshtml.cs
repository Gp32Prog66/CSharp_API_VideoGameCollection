using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageVideoGameCollection.Pages;

public class GetGamesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public GetGamesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
