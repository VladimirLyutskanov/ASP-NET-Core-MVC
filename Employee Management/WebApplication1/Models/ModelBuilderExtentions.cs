using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Mary",
                   Departament = Dept.IT,
                   Email = "mary@abv.bg"

               },
                   new Employee
                   {
                       Id = 2,
                       Name = "John",
                       Departament = Dept.IT,
                       Email = "john@abv.bg"

                   }
               );
        }
    }
}
