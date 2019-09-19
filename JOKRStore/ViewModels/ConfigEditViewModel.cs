using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels {
    public class ConfigEditViewModel {
        public ConfigViewModel Config { get; set; }
        public IEnumerable<CPUViewModel> CPUs { get; set; }
        public IEnumerable<GPUViewModel> GPUs { get; set; }
        public IEnumerable<OSViewModel> OSes { get; set; }

    }
}
