using System;

namespace Model
{
    public class Config
    {
        public Guid Id { get; set; }
        public int RAM { get; set; }
        public int GPUSize { get; set; }
        public string Others { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid CPUId { get; set; }
        public CPU CPU { get; set; }

        public Guid GPUId { get; set; }
        public GPU GPU { get; set; }

        public Guid OSId { get; set; }
        public OS OS { get; set; }
    }
}