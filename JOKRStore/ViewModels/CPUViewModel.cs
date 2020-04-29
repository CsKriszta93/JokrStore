using System;

namespace JOKRStore.Web.ViewModels
{
    public class CPUViewModel
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int manufacturer { get; set; }
        public string architect { get; set; }
        public DateTime release { get; set; }
        public uint freqency { get; set; }
        public uint cores { get; set; }
        public uint cache { get; set; }
    }
}