using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class ForumCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<ForumTopicDto> Topics { get; set; }
    }
}