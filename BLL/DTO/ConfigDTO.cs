using System;

namespace BLL.DTO
{
    public class ConfigDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set; }
        public Guid CPUId { get; set; }
        public CPUDto CPU { get; set; }
        public int RAM { get; set; }
        public Guid GPUId { get; set; }
        public GPUDto GPU { get; set; }
        public int GPUSize { get; set; }
        public Guid OSId { get; set; }
        public OSDto OS { get; set; }
        public string others { get; set; }
    }
}