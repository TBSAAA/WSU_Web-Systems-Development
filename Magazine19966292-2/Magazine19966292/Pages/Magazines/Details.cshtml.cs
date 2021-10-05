using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Magazine19966292.Data;
using Magazine19966292.Model;

namespace Magazine19966292.Pages.Magazines
{
    public class DetailsModel : PageModel
    {
        private readonly Magazine19966292.Data.Magazine19966292Context _context;

        public DetailsModel(Magazine19966292.Data.Magazine19966292Context context)
        {
            _context = context;
        }

        public Magazine Magazine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Magazine = await _context.Magazine.FirstOrDefaultAsync(m => m.ID == id);

            if (Magazine == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
