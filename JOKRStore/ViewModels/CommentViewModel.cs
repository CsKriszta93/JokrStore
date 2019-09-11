using System;
using System.ComponentModel;

namespace JOKRStore.Web.ViewModels
{
    public class CommentViewModel
    {
        public string Contain { get; set; }
        public string CommentDate { get; set; }

        public Guid? GameId { get; set; }
        public GameViewModel Game { get; set; }

        public Guid? ForumTopicId { get; set; }
        public ForumTopicViewModel ForumTopic { get; set; }

        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }
    }
}