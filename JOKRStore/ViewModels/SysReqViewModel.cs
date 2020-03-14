using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels
{
    public class SysReqViewModel
    {
        public Guid Id { get; set; }
        public uint ram { get; set; }
        public uint storage { get; set; }
        public float directx { get; set; }
        public float opengl { get; set; }
        public float vulkan { get; set; }

        public List<SysReqCPUViewModel> SysReqCPUs { get; set; }
        public List<SysReqGPUViewModel> SysReqGPUs { get; set; }
        public List<SysReqOSViewModel> SysReqOSes { get; set; }
    }   
}
