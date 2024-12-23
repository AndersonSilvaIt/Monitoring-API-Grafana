using Industry.Domain.Entities;

namespace Industry.Domain.Repositories
{
    public interface IMachineRepository : IRepository<Machine>
    {
        Task<IEnumerable<Machine>> GetByManufacter(string manufacter);
        Task<IEnumerable<Machine>> GetByYear(int year);
    }
}