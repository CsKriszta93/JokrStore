using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels
{
    public class GameEditViewModel
    {
        public GameViewModel Game { get; set; }
        public PropertyViewModel [] Genres { get; set; }
        public PropertyViewModel [] GameModes { get; set; }
        public IEnumerable<CPUViewModel> CPUs { get; set; }
        public IEnumerable<GPUViewModel> GPUs { get; set; }
        public IEnumerable<OSViewModel> OSes { get; set; }
    }
}