using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class SysReqDto
    {
        public Guid Id { get; set; }
        public uint Ram { get; set; }
        public uint Storage { get; set; }
        public float DirectX { get; set; }
        public float OpenGL { get; set; }
        public float Vulkan { get; set; }

        public List<SysReqCPUDto> SysReqCPUs { get; set; }
        public List<SysReqGPUDto> SysReqGPUs { get; set; }
        public List<SysReqOSDto> SysReqOSes { get; set; }
    }   
}
