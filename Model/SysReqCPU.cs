using System;
using System.Collections.Generic;

namespace Model
{
    public class SysReqCPU
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReq SysReq { get; set; }
        public Guid CPUId { get; set; }
        public CPU CPU { get; set; }
    }
}