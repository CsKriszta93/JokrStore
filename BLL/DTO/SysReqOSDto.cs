using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class SysReqOSDto
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReqDto SysReq { get; set; }
        public Guid OSId { get; set; }
        public OSDto OS { get; set; }
    }
}