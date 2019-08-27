using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels
{
    public class SysReqCPUViewModel
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReqViewModel SysReq { get; set; }
        public Guid CPUId { get; set; }
        public CPUViewModel CPU { get; set; }
    }
}