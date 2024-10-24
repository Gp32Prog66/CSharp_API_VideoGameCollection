using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageVideoGameCollection.Pages;

public class AddControllersAndAccessoriesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AddControllersAndAccessoriesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
