using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace SampleRazorApp.Pages
{
    public class Other2Model : PageModel
    {
        public string? Message { get; set; }
        public bool check { get; set; }
        public Gender gender { get; set; }
        public Platform pc { get; set; }
        public Platform[] pc2 { get; set; }

        public void OnGet()
        {
            Message = "check & select it!";
        }

        public void OnPost(bool check, string gender, Platform pc, Platform[] pc2)
        {
            Message = "Result: " + check + "," + gender + ", " + pc + "," + pc2.Length;
        }
    }
}
