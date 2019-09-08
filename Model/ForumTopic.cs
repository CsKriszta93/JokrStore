using System;
using System.Collections.Generic;

namespace Model {
    public class ForumTopic {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set;}
        public Guid ForumCategoryId { get; set; }
        public ForumCategory ForumCategory { get; set; }
        public List<Comment> Comments { get; set; }
    }
}