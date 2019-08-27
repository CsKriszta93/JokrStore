using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels
{
    public class SysReqGPUViewModel
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReqViewModel SysReq { get; set; }
        public Guid GPUId { get; set; }
        public GPUViewModel GPU { get; set; }

    }
}