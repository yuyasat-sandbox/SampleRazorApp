using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages.Messages
{
    public class CreateModel : PageModel
    {
        private readonly SampleRazorAppContext _context;

        public CreateModel(SampleRazorAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "Name");
            return Page();
        }

        [BindProperty]
        public Message Message { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine("SSSSSS----:" + Message.PersonId);

            Console.WriteLine("SSSSSS22:" + _context.Message == null);

            Console.WriteLine("SSSSSS33:" + Message == null);
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));
                Console.WriteLine("SSSSSS00:" + message);
            }
            if (!ModelState.IsValid || _context.Message == null || Message == null)
            {
                // return Page();
            }

            _context.Message.Add(Message);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
