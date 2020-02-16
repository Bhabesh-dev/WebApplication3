using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class MockEmployeeRepositiry : IEmployeeRepository
    {
        private List<Employee> _employees;

        public MockEmployeeRepositiry()
        {
            _employees = new List<Employee>()
            {
                new Employee() { Id =1,Name="Bhabesh" ,Department ="IT",Email="1@gmail.com" },
                new Employee() { Id =2,Name="Bhabesh2" ,Department ="IT",Email="1@gmail.com" },
                new Employee() { Id =3,Name="Bhabesh3" ,Department ="IT",Email="1@gmail.com" }

            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employees.FirstOrDefault(e=>e.Id ==Id);
            
        }
    }
}
