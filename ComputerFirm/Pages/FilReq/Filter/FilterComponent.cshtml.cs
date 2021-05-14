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
    public class FilterComponentModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public FilterComponentModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public Typesof—omponent Typesof—omponent { get; set; }

        public IList<Component> Component { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Typesof—omponent = _context.Typesof—omponent.First(m => m.ID == id);

            if (Typesof—omponent == null)
            {
                return NotFound();
            }

            Component = await _context.Component.Where(m => m.Typesof—omponent_ID == Typesof—omponent.ID).ToListAsync();
            return Page();
        }
    }
}
