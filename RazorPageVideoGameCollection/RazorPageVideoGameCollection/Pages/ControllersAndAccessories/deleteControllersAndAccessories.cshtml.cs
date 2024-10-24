using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageVideoGameCollection.Pages;

public class DeleteControllersAndAccessoriesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public DeleteControllersAndAccessoriesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
