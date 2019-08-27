using System;
using System.Collections.Generic;

namespace Model
{
    public class SysReqOS
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReq SysReq { get; set; }
        public Guid OSId { get; set; }
        public OS OS { get; set; }
    }
}