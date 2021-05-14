using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ComputerFirm.Data;
using Computerfirm.Models;

namespace ComputerFirm.Pages.TypesOfComponents
{
    public class EditModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public EditModel(ComputerFirm.Data.ComputerFirmContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TypesofСomponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypesofСomponentExists(TypesofСomponent.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TypesofСomponentExists(long id)
        {
            return _context.TypesofСomponent.Any(e => e.ID == id);
        }
    }
}
