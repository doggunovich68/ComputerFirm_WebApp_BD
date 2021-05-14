using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class TypesofСomponent
    {
        [Display(Name = "Код вида")]
        public long ID { get; set; }
        
        [Display(Name = "Наименование")]
        public string NameTypesofComponents { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

    }
}