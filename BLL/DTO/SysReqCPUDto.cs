using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class SysReqCPUDto
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReqDto SysReq { get; set; }
        public Guid CPUId { get; set; }
        public CPUDto CPU { get; set; }
    }
}