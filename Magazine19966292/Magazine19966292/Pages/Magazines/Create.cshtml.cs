using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Magazine19966292.Data;
using Magazine19966292.Model;

namespace Magazine19966292.Pages.Magazines
{
    public class CreateModel : PageModel
    {
        private readonly Magazine19966292.Data.Magazine19966292Context _context;

        public CreateModel(Magazine19966292.Data.Magazine19966292Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Magazine Magazine { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Magazine.Add(Magazine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
