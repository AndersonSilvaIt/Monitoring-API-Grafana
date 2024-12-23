using Industry.Domain.Entities;
using Industry.Domain.Repositories;
using Industry.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Industry.Infrastructure.Repositories
{
    public class MachineRepository : Repository<Machine>, IMachineRepository
    {
        public MachineRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Machine>> GetByManufacter(string manufacter)
        {
            return await _dbSet.AsNoTracking()
                        .Where(x => x.Manufacter.Equals(manufacter, StringComparison.InvariantCultureIgnoreCase))
                        .ToListAsync();
        }

        public async Task<IEnumerable<Machine>> GetByYear(int year)
        {
            return await _dbSet.AsNoTracking()
                               .Where(x => x.Year == year)
                               .ToListAsync();
        }
    }
}
