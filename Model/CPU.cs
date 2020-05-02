using Model.Enums;
using System;

namespace Model
{
    public class CPU
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CPUManufacturer Manufacturer { get; set; }
        public string Architect { get; set; }
        public DateTime Release { get; set; }
        public uint Freqency { get; set; }
        public uint Cores { get; set; }
        public uint Cache { get; set; }
    }
}