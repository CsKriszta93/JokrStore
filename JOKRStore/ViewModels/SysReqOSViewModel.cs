using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels
{
    public class SysReqOSViewModel
    {
        public Guid Id { get; set; }
        public Guid SysReqId { get; set; }
        public SysReqViewModel SysReq { get; set; }
        public Guid OSId { get; set; }
        public OSViewModel OS { get; set; }
    }
}