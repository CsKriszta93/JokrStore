using System;
using System.Collections.Generic;

namespace Model
{
    public class SysReq
    {
        public Guid Id { get; set; }
        public uint ram { get; set; }
        public uint storage { get; set; }
        public float directx { get; set; }
        public float opengl { get; set; }
        public float vulkan { get; set; }

        public List<SysReqCPU> SysReqCPUs { get; set; }
        public List<SysReqGPU> SysReqGPUs { get; set; }
        public List<SysReqOS> SysReqOSes { get; set; }
    }   
}
