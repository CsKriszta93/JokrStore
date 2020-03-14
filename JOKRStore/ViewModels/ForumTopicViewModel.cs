using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels {
    public class ForumTopicViewModel {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public Guid UserId { get; set; }
        public UserViewModel User { get; set;}
        public Guid ForumCategoryId { get; set; }
        public ForumCategoryViewModel ForumCategory { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}