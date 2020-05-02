using System.ComponentModel.DataAnnotations;

namespace Model.Enums
{
    public enum OSGroup
    {
        [Display(Name = "Windows")]
        Windows,

        [Display(Name = "ReactOS")]
        ReactOS,

        [Display(Name = "Mac OS X")]
        MacOSX,

        [Display(Name = "Ubuntu")]
        Ubuntu,

        [Display(Name = "Debian")]
        Debian,

        [Display(Name = "SUSE Linux")]
        SuseLinux,

        [Display(Name = "Linux Mint")]
        LinuxMint
    }
}
