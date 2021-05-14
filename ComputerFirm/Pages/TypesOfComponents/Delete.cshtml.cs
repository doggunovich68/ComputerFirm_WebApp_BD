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
    public class DeleteModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public DeleteModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesofСomponent = await _context.TypesofСomponent.FindAsync(id);

            if (TypesofСomponent != null)
            {
                _context.TypesofСomponent.Remove(TypesofСomponent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
