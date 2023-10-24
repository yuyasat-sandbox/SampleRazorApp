using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace SampleRazorApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string Message { get; set; } = "sample message";

    [DataType(DataType.Text)]
    public string Name { get; set; }

    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Mail { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string Tel { get; set; }

    [BindProperty(SupportsGet = true)]
    public int Num { get; set; }

    public void OnGet()
    {
        Message = "何か書いてください。";

    }

    public void OnPost(string name, string password, string mail, string tel)
    {
        Message = "[Name: " + name + ", password:(" + password.Length + " chargs), mail:" + mail + " <" + tel + ">]";
    }

}

