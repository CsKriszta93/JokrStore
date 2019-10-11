using System;

namespace JOKRStore.Web.ViewModels
{
    public class PropertyViewModel
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public bool Selected {get; set; }
    }
}