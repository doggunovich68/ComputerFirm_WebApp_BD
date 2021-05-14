using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Computerfirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ComputerFirm.Pages.FilReq.Request
{
    public class PerDepModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public PerDepModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }
        public IList<Staff> Staff { get; set; }
        public IList<Position> Position { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            Position = await _context.Position.ToListAsync();
        }
    }
}
