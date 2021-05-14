
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Computerfirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Component = Computerfirm.Models.Component;

namespace ComputerFirm.Pages.FilReq.Request
{
    public class ListComponentModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public ListComponentModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }
        public IList<Component> Component { get; set; }
        public IList<Typesof—omponent> Typesof—omponent { get; set; }

        public async Task OnGetAsync()
        {
            Component = await _context.Component.ToListAsync();
            Typesof—omponent = await _context.Typesof—omponent.ToListAsync();
        }
    }
}
