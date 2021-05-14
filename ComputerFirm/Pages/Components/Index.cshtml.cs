using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ComputerFirm.Data;
using Computerfirm.Models;

namespace ComputerFirm.Pages.Components
{
    public class IndexModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public IndexModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public IList<Component> Component { get;set; }
        public IList<TypesofСomponent> TypesofСomponent { get;set; }

        public async Task OnGetAsync()
        {
            Component = await _context.Component.ToListAsync();
            TypesofСomponent = await _context.TypesofСomponent.ToListAsync();
        }
    }
}
