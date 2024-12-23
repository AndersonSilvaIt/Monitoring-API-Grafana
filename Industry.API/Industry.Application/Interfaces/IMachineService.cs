using Industry.Application.DTOs;

namespace Industry.Application.Interfaces
{
    public interface IMachineService
    {
        Task<IEnumerable<MachineDTO>> GetAll();
        Task<MachineDTO> GetById(Guid id);
        Task<MachineDTO> AddAsync(MachineDTO machineDTO);
        
    }
}