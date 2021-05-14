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
    public class ListOrdersModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public ListOrdersModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }
        public IList<Component> Component { get; set; }
        public IList<Customer> Customer { get; set; }
        public IList<Order> Order { get; set; }
        public IList<Service> Service { get; set; }
        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Component = await _context.Component.ToListAsync();
            Customer = await _context.Customer.ToListAsync();
            Order = await _context.Order.ToListAsync();
            Service = await _context.Service.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
