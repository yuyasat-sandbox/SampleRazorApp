using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SampleRazorAppContext _context;

        public IndexModel(SampleRazorAppContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Person != null)
            {
                Person = await _context.Person.Include("Messages").ToListAsync();
            }
        }
    }
}
