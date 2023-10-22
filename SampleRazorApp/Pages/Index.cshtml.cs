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
    private string[][] data = new string[][]
    {
        new string []{"Taro", "taro@yamada"},
        new string []{"Hanako", "hanako@flower"},
        new string []{"Sachiko", "sachiko@happy"},
    };
    [BindProperty(SupportsGet = true)]
    public int id { get; set; }

    public void OnGet()
    {
        Message = "何か書いてください。";

    }

    public string getData(int id)
    {
        string[] target = data[id];
        return "[名前:" + target[0] + ", メール:" + target[1] + "]";
    }
}

