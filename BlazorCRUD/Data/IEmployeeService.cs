using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetEmployees();
    }
}
