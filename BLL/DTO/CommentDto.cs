using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class CommentDto
    {
        //public Guid CommentId { get; set; }
        public Guid Commenter { get; set; }
        public DateTime CommentDate { get; set; }
        public string Contain { get; set; }

        public Guid GameId { get; set; }

        public UserDto user { get; set; }

    }
}
