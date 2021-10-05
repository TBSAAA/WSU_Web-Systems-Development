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
    public class IndexModel : PageModel
    {
        private readonly Magazine19966292.Data.Magazine19966292Context _context;

        public IndexModel(Magazine19966292.Data.Magazine19966292Context context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {

            var customer = (IQueryable<Customer>)_context.Customer;

            if (!String.IsNullOrEmpty(SearchString))
            {
                customer = customer.Where(s => s.FamilyName.Contains(SearchString) || s.GivenName.Contains(SearchString));
            }


            Customer = await customer.ToListAsync();
        }
    }
}
