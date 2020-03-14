using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels {
    public class ForumCategoryViewModel {
        public Guid Id { get; set; }
        public string name { get; set; }
        public List<ForumTopicViewModel> topics { get; set; }
    }
}