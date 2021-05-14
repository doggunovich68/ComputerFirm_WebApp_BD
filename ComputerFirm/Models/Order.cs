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

        [Display(Name = "Дата заказа")]
        public DateTime OrderData { get; set; }
        [Display(Name = "Дата исполнения")]
        
        public DateTime DueData { get; set; }

        [Display(Name = "Доля предоплаты")]
        public int ShareofPrepayment { get; set; }


        [Display(Name = " Отметка об оплате")]
        public Boolean  PaymentMark { get; set; }


        [Display(Name = "Отметка об исполнении")]
        public Boolean  ExecutionMark{ get; set; }
        [Display(Name = "Срок общей гарантии")]
        public DateTime GeneralWarranttyPeriod { get; set; }
        [Display(Name = "Общая стоимость")]
        
        public int TotalCost { get; set; }
        [Display(Name = "Заказчик")]
        public DbSet<Customer> CustomerID { get; set; }

        [Display(Name = "Код заказчика")]
        public long Customer_ID { get; set; }




        [Display(Name = "Комплектующие 1")]
        public DbSet<Component> Component1ID { get; set; }

        [Display(Name = "Код комплектующего 1")]
        public long Component_1ID { get; set; }




        [Display(Name = "Комплектующие 2")]
        public DbSet<Component> Component2ID { get; set; }

        [Display(Name = "Код комплектующего 2")]
        public long Component_2ID { get; set; }




        [Display(Name = "Комплектующие 3")]
        public DbSet<Component> Component3ID { get; set; }

        [Display(Name = "Код комплектующего 3")]
        public long Component_3ID { get; set; }





        [Display(Name = "Услуга 1")]
        public DbSet<Service> Service1ID { get; set; }

        [Display(Name = "Код услуги 1")]
        public long Service_1ID { get; set; }




        [Display(Name = "Услуга 2")]
        public DbSet<Service> Service2ID { get; set; }

        [Display(Name = "Код услуги 2")]
        public long Service_2ID { get; set; }



        [Display(Name = "Услуга 3")]
        public DbSet<Service> Service3ID { get; set; }


        [Display(Name = "Код услуги 3")]
        public long Service_3ID { get; set; }


        [Display(Name = " Сотрудник")]
        public DbSet<Staff> StaffID { get; set; }

        [Display(Name = "Код сотрудника")]
        public long Staff_ID { get; set; }
    }
}