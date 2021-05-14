using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ComputerFirm.Data;
using Computerfirm.Models;

namespace ComputerFirm.Pages.TypesOfComponents
{
    public class DetailsModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public DetailsModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public TypesofСomponent TypesofСomponent { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesofСomponent = await _context.TypesofСomponent.FirstOrDefaultAsync(m => m.ID == id);

            if (TypesofСomponent == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
