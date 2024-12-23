using AutoMapper;
using Industry.Application.DTOs;
using Industry.Application.Interfaces;
using Industry.Domain.Entities;
using Industry.Domain.Repositories;

namespace Industry.Application.Services
{
    public class MachineService : IMachineService
    {
        private readonly IMachineRepository _machineRepository;
        private readonly IMapper _mapper;

        public MachineService(IMachineRepository machineRepository, IMapper mapper)
        {
            _machineRepository = machineRepository;
            _mapper = mapper;
        }

        public async Task<MachineDTO> AddAsync(MachineDTO machineDTO)
        {
            await _machineRepository.AddAsync(_mapper.Map<Machine>(machineDTO));

            return new MachineDTO();
        }

        public async Task<IEnumerable<MachineDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<MachineDTO>>(await _machineRepository.GetAllAsync());
        }

        public async Task<MachineDTO> GetById(Guid id)
        {
            return _mapper.Map<MachineDTO>(await _machineRepository.GetByIdAsync(id));
        }
    }
}