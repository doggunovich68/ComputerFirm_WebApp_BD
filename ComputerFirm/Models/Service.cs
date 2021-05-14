using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Service
    {
        [Display(Name = "��� ������")]
        public long ID { get; set; }

        [Display(Name = "������������")]
        public string Name { get; set; }
        [Display(Name = "���������")]
        public int Price { get; set; }
        [Display(Name = "��������")]

        public string Description { get; set; }
    }
}