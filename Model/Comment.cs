using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comment
    {
        public Guid CommentId { get; set; }
        public Guid Commenter { get; set; }
        public DateTime CommentDate { get; set; }
        public string Contain { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}
