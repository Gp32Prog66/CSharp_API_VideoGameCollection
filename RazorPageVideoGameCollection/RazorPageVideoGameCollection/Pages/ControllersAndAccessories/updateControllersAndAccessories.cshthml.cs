using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageVideoGameCollection.Pages;

public class UpdateControllersAndAccessoriesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public UpdateControllersAndAccessoriesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
