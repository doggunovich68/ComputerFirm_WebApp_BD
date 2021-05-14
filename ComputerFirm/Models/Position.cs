using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Position
    {
        [Display(Name = "Код должности")]
        public long ID { get; set; }
        

        [Display(Name = "Наименование должности")]
        public string NamePosition { get; set; }

        [Display(Name = "Оклад")]
        public string Salary { get; set; }

        [Display(Name = "Обязанности")]
        public string Duties { get; set; }

        [Display(Name = "Требования")]
        public string Requirements { get; set; }

    }
}