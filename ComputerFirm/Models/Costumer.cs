using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Customer
    {

        [Display(Name = "Код заказчика")]
        public long ID { get; set; }

        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [Display(Name = "Телефон")]
        public int Telephone { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }
       

    }
}