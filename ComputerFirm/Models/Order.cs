using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Order
    {
        public long ID { get; set; }

        [Display(Name = "���� ������")]
        public DateTime OrderData { get; set; }
        [Display(Name = "���� ����������")]
        
        public DateTime DueData { get; set; }

        [Display(Name = "���� ����������")]
        public int ShareofPrepayment { get; set; }


        [Display(Name = " ������� �� ������")]
        public Boolean  PaymentMark { get; set; }


        [Display(Name = "������� �� ����������")]
        public Boolean  ExecutionMark{ get; set; }
        [Display(Name = "���� ����� ��������")]
        public DateTime GeneralWarranttyPeriod { get; set; }
        [Display(Name = "����� ���������")]
        
        public int TotalCost { get; set; }
        [Display(Name = "��������")]
        public DbSet<Customer> CustomerID { get; set; }

        [Display(Name = "��� ���������")]
        public long Customer_ID { get; set; }




        [Display(Name = "������������� 1")]
        public DbSet<Component> Component1ID { get; set; }

        [Display(Name = "��� �������������� 1")]
        public long Component_1ID { get; set; }




        [Display(Name = "������������� 2")]
        public DbSet<Component> Component2ID { get; set; }

        [Display(Name = "��� �������������� 2")]
        public long Component_2ID { get; set; }




        [Display(Name = "������������� 3")]
        public DbSet<Component> Component3ID { get; set; }

        [Display(Name = "��� �������������� 3")]
        public long Component_3ID { get; set; }





        [Display(Name = "������ 1")]
        public DbSet<Service> Service1ID { get; set; }

        [Display(Name = "��� ������ 1")]
        public long Service_1ID { get; set; }




        [Display(Name = "������ 2")]
        public DbSet<Service> Service2ID { get; set; }

        [Display(Name = "��� ������ 2")]
        public long Service_2ID { get; set; }



        [Display(Name = "������ 3")]
        public DbSet<Service> Service3ID { get; set; }


        [Display(Name = "��� ������ 3")]
        public long Service_3ID { get; set; }


        [Display(Name = " ���������")]
        public DbSet<Staff> StaffID { get; set; }

        [Display(Name = "��� ����������")]
        public long Staff_ID { get; set; }
    }
}