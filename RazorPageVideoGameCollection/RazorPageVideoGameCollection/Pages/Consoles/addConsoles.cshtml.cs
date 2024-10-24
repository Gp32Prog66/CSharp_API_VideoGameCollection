using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageVideoGameCollection.Pages;

public class AddConsolesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AddConsolesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
