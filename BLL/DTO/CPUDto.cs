using System;

namespace BLL.DTO
{
    public class CPUDto
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string architect { get; set; }
        public DateTime release { get; set; }
        public uint freqency { get; set; }
        public uint cores { get; set; }
        public uint cache { get; set; }
    }
}