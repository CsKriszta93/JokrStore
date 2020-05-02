using System.ComponentModel.DataAnnotations;

namespace Model.Enums
{
    public enum GPUManufacturer
    {
        [Display(Name = "Nvidia")]
        Nvidia,

        [Display(Name = "AMD")]
        AMD,

        [Display(Name = "Intel")]
        Intel,

        [Display(Name = "S3 Graphics")]
        S3Graphics
    }
}
