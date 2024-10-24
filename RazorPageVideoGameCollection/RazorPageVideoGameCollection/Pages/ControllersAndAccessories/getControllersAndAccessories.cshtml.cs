using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageVideoGameCollection.Pages;

public class GetControllersAndAccessoriesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public GetControllersAndAccessoriesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
