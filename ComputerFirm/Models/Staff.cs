using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Staff
    {
        [Display(Name = "��� ����������")]
        public long ID { get; set; }
        [Display(Name ="���")]
        public string FullName { get; set; }
        [Display(Name = "�������")]
        public short Age { get; set; }
        [Display(Name = "���")]
        public string Gender { get; set; }
        [Display(Name = "�����")]
        public string Address { get; set; }
        [Display(Name = "�������")]
        public int Phone { get; set; }
        [Display(Name = "���������� ������")]
        public string PassportData { get; set; }

        [Display(Name = "���������")]
        public DbSet <Position> Position{ get; set; }

        [Display(Name = "��� ���������")]
        public long Position_ID { get; set; }

    }
}