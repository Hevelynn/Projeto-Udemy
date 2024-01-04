using ProjetoUdemy.Data;
using ProjetoUdemy.Models;

namespace ProjetoUdemy.Services
{
    public class DepartmentService
    {
        private readonly ProjetoUdemyContext _context;

        public DepartmentService(ProjetoUdemyContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
