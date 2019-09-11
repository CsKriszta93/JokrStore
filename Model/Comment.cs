using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comment
    {
        public Comment()
        {
            CommentId = new Guid();
        }

        public Guid CommentId { get; set; }
        public DateTime CommentDate { get; set; }
        public string Contain { get; set; }

        public Guid? GameId { get; set; }
        public Game Game { get; set; }

        public Guid? ForumTopicId { get; set; }
        public ForumTopic ForumTopic { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
