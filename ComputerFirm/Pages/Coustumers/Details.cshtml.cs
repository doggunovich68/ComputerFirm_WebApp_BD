using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ComputerFirm.Data;
using Computerfirm.Models;

namespace ComputerFirm.Pages.Coustumers
{
    public class DetailsModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public DetailsModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID== id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
