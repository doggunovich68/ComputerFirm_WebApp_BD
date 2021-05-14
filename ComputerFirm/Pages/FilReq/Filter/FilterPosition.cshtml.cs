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
    public class FilterPositionModel : PageModel
    {
       
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public FilterPositionModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public Position Position { get; set; }

        public IList<Staff> Staff { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = _context.Position.First(m => m.ID == id);

            if (Position == null)
            {
                return NotFound();
            }

            Staff = await _context.Staff.Where(m=> m.Position_ID == Position.ID).ToListAsync();
            return Page();
        }
        
    }
}
