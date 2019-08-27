using System;

namespace JOKRStore.Web.ViewModels
{
    public class GPUViewModel
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string architect { get; set; }
        public DateTime release { get; set; }
        public uint memory_size { get; set; }
        public float shader_model { get; set; }
        public float directx { get; set; }
        public float opengl { get; set; }
        public float vulkan { get; set; }
        public uint memory_freqency { get; set; }
        public uint core_frequency { get; set; }
        public uint shaders { get; set; }
        public uint buswidth { get; set; }
        public uint bandwidth { get; set; }
        public uint pixel_fillrate { get; set; }
        public uint texture_fillrate { get; set; }
    }
}