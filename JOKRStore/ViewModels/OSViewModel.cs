using System;

namespace JOKRStore.Web.ViewModels
{
    public class OSViewModel
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int group { get; set; }
        public int major_ver { get; set; }
        public int minor_ver { get; set; }
    }
}