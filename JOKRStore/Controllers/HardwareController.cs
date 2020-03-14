using JOKRStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AutoMapper;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace JOKRStore.Web.Controllers
{
    public class HardwareController : Controller
    {
        private readonly IHardwareService hardwareService;
        private readonly IMapper mapper;

        public HardwareController(IHardwareService hardwareService, IMapper mapper)
        {
            this.hardwareService = hardwareService;
            this.mapper = mapper;
        }

        public async Task<JsonResult> SetGPUFilter(string Facturer)
        {
            var GPUDtos = (await hardwareService.GetGPUsAsync()).Where(x => x.manufacturer == int.Parse(Facturer));
            var GPUs = mapper.Map<IEnumerable<GPUViewModel>>(GPUDtos);
            return Json(GPUs);
        }

        public async Task<JsonResult> SetCPUFilter(string Facturer)
        {
            var CPUDtos = (await hardwareService.GetCPUsAsync()).Where(x => x.manufacturer == int.Parse(Facturer));
            var CPUs = mapper.Map<IEnumerable<CPUViewModel>>(CPUDtos);
            return Json(CPUs);
        }

        public async Task<JsonResult> SetOSFilter(string Group)
        {
            var OSDtos = (await hardwareService.GetOSesAsync()).Where(x => x.group == int.Parse(Group));
            var OSes = mapper.Map<IEnumerable<OSViewModel>>(OSDtos);
            return Json(OSes);
        }
    }
}