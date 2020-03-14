using System;
using System.Collections.Generic;

namespace Model {
    public class ForumCategory {
        public Guid Id { get; set; }
        public string name { get; set; }
        public List<ForumTopic> topics { get; set; }
    }
}