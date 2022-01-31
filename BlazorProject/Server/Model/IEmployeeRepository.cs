using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorProject.Shared;

namespace BlazorProject.Server.Model
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeID);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee employee);

        Task<Employee> UpdateEmployee(Employee employee);
        Task DeleteEmployee(int employeeID);
        Task GetEmployee(string firstName);
    }
}
