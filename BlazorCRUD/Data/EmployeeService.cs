using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCRUD.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>
        {
            new EmployeeModel
            {
                Id = Guid.NewGuid(),
                Name = "Bob Smith",
                Age = 27
            },
            new EmployeeModel
            {
                Id = Guid.NewGuid(),
                Name = "Mary Johnson",
                Age = 23
            }
        };

        public void AddEmployee(EmployeeModel employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid employeeId)
        {
            var employee = GetEmployee(employeeId);
            employees.Remove(employee);
        }

        public EmployeeModel GetEmployee(Guid employeeId)
        {
            return employees.SingleOrDefault(e => e.Id == employeeId);
        }

        public List<EmployeeModel> GetEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            var oldEmployee = GetEmployee(employee.Id);
            oldEmployee.Name = employee.Name;
            oldEmployee.Age = employee.Age;
        }
    }
}
