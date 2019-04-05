using System;

namespace JOKRStore.Web.ViewModels
{
    public class CommentViewModel
    {
        public Guid Commenter { get; set; }
        public DateTime CommentDate { get; set; }
        public string Contain { get; set; }
    }
}
