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

    public string Message { get; set; } = "sample message";
    private string Name = "no-name";
    private string Mail = "no-mail";

    public void OnGet()
    {
        Message = "これは新たに設定されたメッセージです！！";

    }

    public string getData()
    {
        return "[名前:" + Name + ", メール:" + Mail + "]";
    }
}

