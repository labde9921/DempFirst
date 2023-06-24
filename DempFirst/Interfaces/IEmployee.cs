using DempFirst.Entities;

namespace DempFirst.Interfaces
{
    public interface IEmployee
    {
        int Create(Employee employee);
        int Update(Employee employee);
        int Delete(int empId);
        Employee Detail(int empId);
        List<Employee> GetAll();
    }
}
