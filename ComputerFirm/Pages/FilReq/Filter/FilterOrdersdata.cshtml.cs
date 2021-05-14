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
    public class FilterOrdersdataModel : PageModel
    {
        private readonly Data.ComputerFirmContext _context;

        public FilterOrdersdataModel(Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public Order OrderData { get; set; }

        public IList<Order> Order { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderData =  _context.Order.First(m => m.ID == id);

            if (OrderData == null)
            {
                return NotFound();
            }

            Order = await _context.Order.Where(m => m.ID == OrderData.ID).ToListAsync();
            return Page();
        }
    }
}
