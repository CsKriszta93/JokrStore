using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class SysReqDto
    {
        public Guid Id { get; set; }
        public uint ram { get; set; }
        public uint storage { get; set; }
        public float directx { get; set; }
        public float opengl { get; set; }
        public float vulkan { get; set; }

        public List<SysReqCPUDto> SysReqCPUs { get; set; }
        public List<SysReqGPUDto> SysReqGPUs { get; set; }
        public List<SysReqOSDto> SysReqOSes { get; set; }
    }   
}
