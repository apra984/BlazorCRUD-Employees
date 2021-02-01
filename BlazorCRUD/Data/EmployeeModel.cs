using System;

namespace BlazorCRUD.Data
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}