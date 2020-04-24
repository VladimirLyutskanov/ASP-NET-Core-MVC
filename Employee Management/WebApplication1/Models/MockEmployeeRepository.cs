using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private  List<Employee> employeeList;

        public MockEmployeeRepository()
        {
            employeeList = new List<Employee>()
            {
                new Employee (){Id = 1, Name="Mary", Departament=Dept.HR, Email="mary@abv.bg"},
                new Employee (){Id = 2, Name="John", Departament=Dept.IT, Email="john@abv.bg"},
                new Employee (){Id = 3, Name="Sam", Departament=Dept.Payroll, Email="sam@abv.bg"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = employeeList.Max(maxID => maxID.Id) + 1;
            employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = employeeList.FirstOrDefault(e => e.Id == id);
            if (employee !=null)
            {
                employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return employeeList.FirstOrDefault(emp => emp.Id == id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Departament = employeeChanges.Departament;
            }
            return employee;
        }
    }
}
