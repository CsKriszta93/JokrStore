using System;
using System.Collections.Generic;

namespace Model
{
    public class SysReqGPU
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReq SysReq { get; set; }
        public Guid GPUId { get; set; }
        public GPU GPU { get; set; }

    }
}