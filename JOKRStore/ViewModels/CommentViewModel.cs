using System;
using System.ComponentModel;

namespace JOKRStore.Web.ViewModels
{
    public class CommentViewModel
    {
        public Guid UserId { get; set; }

        public string Contain { get; set; }

        public string CommentDate { get; set; }

        public Guid GameId { get; set; }

        public UserViewModel User { get; set; }
    }
}
