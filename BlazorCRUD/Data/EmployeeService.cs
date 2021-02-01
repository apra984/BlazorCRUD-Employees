using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public List<EmployeeModel> GetEmployees()
        {
            return employees;
        }
    }
}
