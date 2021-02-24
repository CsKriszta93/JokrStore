using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JokrStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class HardwareController : ControllerBase
    {
        private readonly IHardwareService hardwareService;

        public HardwareController(IHardwareService hardwareService)
        {
            this.hardwareService = hardwareService;
        }

        [HttpGet("cpus")]
        public async Task<IActionResult> GetCpus()
        {
            return Ok(await hardwareService.GetCPUsAsync());
        }

        [HttpGet("gpus")]
        public async Task<IActionResult> GetGpus()
        {
            return Ok(await hardwareService.GetGPUsAsync());
        }

        [HttpGet("oses")]
        public async Task<IActionResult> GetOperationSystems()
        {
            return Ok(await hardwareService.GetOSesAsync()); 
        }

        [HttpGet("cpu-manufacturers")]
        public async Task<IActionResult> GetCpuManufacturersForSelectList()
        {
            return Ok(hardwareService.GetCPUManufacturersForSelectList());
        }

        [HttpGet("gpu-manufacturers")]
        public async Task<IActionResult> GetGpuManufacturersForSelectList()
        {
            return Ok(hardwareService.GetGPUManufacturersForSelectList());
        }

        [HttpGet("os-groups")]
        public async Task<IActionResult> GetOsGroupsForSelectList()
        {
            return Ok(hardwareService.GetOSGroupForSelectList());
        }
    }
}