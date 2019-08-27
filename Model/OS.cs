using System;

namespace Model
{
    public class OS
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int group { get; set; }
        public int major_ver { get; set; }
        public int minor_ver { get; set; }
    }
}