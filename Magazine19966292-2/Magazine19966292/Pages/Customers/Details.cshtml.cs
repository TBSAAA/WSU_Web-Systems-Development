using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Magazine19966292.Data;
using Magazine19966292.Model;

namespace Magazine19966292.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly Magazine19966292.Data.Magazine19966292Context _context;

        public DetailsModel(Magazine19966292.Data.Magazine19966292Context context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
