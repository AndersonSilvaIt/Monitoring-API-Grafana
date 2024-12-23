using Industry.Application.DTOs;
using Industry.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Industry.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MachineController : ControllerBase
    {
        private readonly IMachineService _machineService;

        public MachineController(IMachineService machineService)
        {
            _machineService = machineService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _machineService.GetAll());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _machineService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(MachineDTO machineDto)
        {
            return Ok(await _machineService.AddAsync(machineDto));
        }
    }
}