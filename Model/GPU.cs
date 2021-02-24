using Model.Enums;
using System;

namespace Model
{
    public class GPU
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GPUManufacturer Manufacturer { get; set; }
        public string Architect { get; set; }
        public DateTime Release { get; set; }
        public uint MemorySize { get; set; }
        public float ShaderModel { get; set; }
        public float DirectX { get; set; }
        public float OpenGl { get; set; }
        public float Vulkan { get; set; }
        public uint MemoryFreqency { get; set; }
        public uint CoreFrequency { get; set; }
        public uint Shaders { get; set; }
        public uint Buswidth { get; set; }
        public uint Bandwidth { get; set; }
        public uint PixelFillRate { get; set; }
        public uint TextureFillRate { get; set; }
    }
}