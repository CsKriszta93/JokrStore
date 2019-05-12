using System;
using System.ComponentModel;

namespace JOKRStore.Web.ViewModels
{
    public class CommentViewModel
    {
        public Guid CommentId { get; set; }

        public Guid CommenterId { get; set; }

        [DisplayName("Name")]
        public string CommenterName { get; set; }

        public string Contain { get; set; }

        public DateTime CommentDate { get; set; }

        public UserViewModel User { get; set; } 

        public Guid GameId { get; set; }
    }
}
