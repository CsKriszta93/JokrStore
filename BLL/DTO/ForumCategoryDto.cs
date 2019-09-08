using System;
using System.Collections.Generic;

namespace BLL.DTO {
    public class ForumCategoryDto {
        public Guid Id { get; set; }
        public string name { get; set; }
        public List<ForumTopicDto> topics { get; set; }
    }
}