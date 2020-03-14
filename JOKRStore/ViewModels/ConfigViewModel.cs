using System;

namespace JOKRStore.Web.ViewModels {
    public class ConfigViewModel {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }
        public Guid CPUId { get; set; }
        public CPUViewModel CPU { get; set; }
        public int RAM { get; set; }
        public Guid GPUId { get; set; }
        public GPUViewModel GPU { get; set; }
        public int GPU_size { get; set; }
        public Guid OSId { get; set; }
        public OSViewModel OS { get; set; }
        public string others { get; set; }

    }
}