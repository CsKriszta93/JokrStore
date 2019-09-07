using System;

namespace Model {
    public class Config {
        public Guid Id { get; set; }
        public Guid CPUId { get; set; }
        public CPU CPU { get; set; }
        public int RAM { get; set; }
        public Guid GPUId { get; set; }
        public GPU GPU { get; set; }
        public int GPU_size { get; set; }
        public Guid OSId { get; set; }
        public OS OS { get; set; }
        public string others { get; set; }

    }
}