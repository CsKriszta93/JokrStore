using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class MediaDto
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public int type { get; set; }
        public string contain { get; set; }
    }
}
