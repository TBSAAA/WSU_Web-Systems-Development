using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Magazine19966292.Data;
using Magazine19966292.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Magazine19966292.Pages.Magazines
{
    public class PurchaseModel : PageModel
    {
        private readonly Magazine19966292.Data.Magazine19966292Context _context;
        public PurchaseModel(Magazine19966292.Data.Magazine19966292Context context)
        {
            _context = context;
        }

        // Requires 'using Microsoft.AspNetCore.Mvc.Rendering;'
        public SelectList TitleList { get; set; }

        [BindProperty(SupportsGet = true)]
        public MagazinePurchase MagazinePurchase { get; set; }

        public IActionResult OnGet()
        {
            // Obtain values for the <select> list in web form
            TitleList = new SelectList(_context.Magazine, "MagazineName", "MagazineName");
            // Display the page
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Obtain values for the <select> list in web form
            TitleList = new SelectList(_context.Magazine, "MagazineName", "MagazineName");

            if (!ModelState.IsValid)  // validate user input
            {
                return Page();
            }

            var magazine = await _context.Magazine.FirstOrDefaultAsync(m => m.MagazineName == MagazinePurchase.MagazineTitle);
            ViewData["TotalPrice"] = magazine.Price * MagazinePurchase.MagazineCount;
            return Page();
        }


    }
}
