using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class SysReqGPUDto
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReqDto SysReq { get; set; }
        public Guid GPUId { get; set; }
        public GPUDto GPU { get; set; }

    }
}