using System;

namespace JOKRStore.Web.ViewModels
{
    public class DescriptionViewModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public int Language { get; set; }
    }
}