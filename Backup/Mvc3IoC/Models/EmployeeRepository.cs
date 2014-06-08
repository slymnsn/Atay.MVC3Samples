namespace Mvc3IoC.Models
{
    using System.Linq;

    public class EmployeeRepository : IRepository
    {
        private NorthwindEntities context = new NorthwindEntities();

        public void Insert(Employee employee)
        {
            this.context.Employees.AddObject(employee);
        }

        public void Delete(int id)
        {
            this.context.Employees.DeleteObject(new Employee { EmployeeID = id });
        }

        public IQueryable<Employee> GetAll()
        {
            return this.context.Employees.AsQueryable();
        }
    }
}