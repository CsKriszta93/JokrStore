using System;
using System.Collections.Generic;

namespace Model
{
    public class SysReq
    {
        public Guid Id { get; set; }
        public uint Ram { get; set; }
        public uint Storage { get; set; }
        public float DirectX { get; set; }
        public float OpenGL { get; set; }
        public float Vulkan { get; set; }

        public List<SysReqCPU> SysReqCPUs { get; set; }
        public List<SysReqGPU> SysReqGPUs { get; set; }
        public List<SysReqOS> SysReqOSes { get; set; }
    }   
}
