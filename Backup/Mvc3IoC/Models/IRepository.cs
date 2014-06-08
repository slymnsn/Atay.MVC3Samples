namespace Mvc3IoC.Models
{
    using System.Linq;

    public interface IRepository
    {
        void Insert(Employee employee);

        void Delete(int id);

        IQueryable<Employee> GetAll();
    }
}