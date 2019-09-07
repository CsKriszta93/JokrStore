using System;

namespace BLL.DTO {
    public class ConfigDto {
        public Guid Id { get; set; }
        public Guid CPUId { get; set; }
        public CPUDto CPU { get; set; }
        public int RAM { get; set; }
        public Guid GPUId { get; set; }
        public GPUDto GPU { get; set; }
        public int GPU_size { get; set; }
        public Guid OSId { get; set; }
        public OSDto OS { get; set; }
        public string others { get; set; }
    }
}