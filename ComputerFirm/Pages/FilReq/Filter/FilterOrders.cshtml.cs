using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Computerfirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComputerFirm.Pages.FilReq.Filter
{
    public class FilterOrdersModel : PageModel
    {
        private readonly Data.ComputerFirmContext _context;

        public FilterOrdersModel(Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public IList<Order> Order { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = _context.Customer.First(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }

            Order = await _context.Order.Where(m => m.Customer_ID == Customer.ID).ToListAsync();
            return Page();
        }
    }
}
