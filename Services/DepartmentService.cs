using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
