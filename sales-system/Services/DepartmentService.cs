using sales_system.Data;
using sales_system.Models;

namespace sales_system.Services
{
    public class DepartmentService
    {
        private readonly sales_systemContext _context;

        public DepartmentService(sales_systemContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
