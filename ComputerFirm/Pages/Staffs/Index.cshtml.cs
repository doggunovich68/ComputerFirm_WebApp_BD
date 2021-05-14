using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ComputerFirm.Data;
using Computerfirm.Models;

namespace ComputerFirm.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public IndexModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }

        public IList<Position> Position { get; set; }
        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            Position = await _context.Position.ToListAsync();
        }
    }
}
