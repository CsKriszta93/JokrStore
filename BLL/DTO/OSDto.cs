using System;
using Model.Enums;

namespace BLL.DTO
{
    public class OSDto
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public OSGroup group { get; set; }
        public int major_ver { get; set; }
        public int minor_ver { get; set; }
    }
}