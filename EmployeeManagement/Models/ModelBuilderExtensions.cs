using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
             new Employee
             {
                 Id = 1,
                 Name = "Mary",
                 Department = Department.IT,
                 Email = "mary@mary.com"
             },
              new Employee
              {
                  Id = 2,
                  Name = "John",
                  Department = Department.IT,
                  Email = "john@jhon.com"
              }
             );
        }
    }
}
