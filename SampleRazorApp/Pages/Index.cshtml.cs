using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazorApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    [ViewData]
    public string Message { get; set; } = "sample message";
    public void OnGet()
    {
        Message = "これは新たに設定されたメッセージです！！";

    }
}

