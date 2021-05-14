using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Computerfirm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComputerFirm.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public IndexModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }
        //public IList<Staff> Staff { get; set; }
        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> SelComp { get; set; }
        public List<SelectListItem> SelOrd { get; set; }
        public List<SelectListItem> OrderData { get; set; }

        public void OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                new SelectListItem {
                    Value = p.ID.ToString(),
                    Text = p.NamePosition
                }).ToList();
            SelComp = _context.Component.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Brand
                }).ToList();
            SelOrd = _context.Order.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Customer_ID.ToString()
                }).ToList();
            OrderData = _context.Order.Select(p =>
               new SelectListItem
               {
                   Value = p.ID.ToString(),
                   Text = p.OrderData.ToString()
               }).ToList();
        }
    }
}
