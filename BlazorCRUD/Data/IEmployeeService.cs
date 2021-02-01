using System;
using System.Collections.Generic;

namespace BlazorCRUD.Data
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetEmployees();

        EmployeeModel GetEmployee(Guid employeeId);

        void UpdateEmployee(EmployeeModel employee);

        void AddEmployee(EmployeeModel employee);

        void DeleteEmployee(Guid employeeId);
    }
}
