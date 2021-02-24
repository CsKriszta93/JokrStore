using Model.Enums;
using System;

namespace Model
{
    public class OS
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public OSGroup Group { get; set; }
        public int MajorVer { get; set; }
        public int MinorVer { get; set; }
    }
}