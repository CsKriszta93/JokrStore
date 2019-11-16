using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace JOKRStore.Web.ViewModels
{
    public class GameViewModel
    {
        public Guid Id { get; set; }

        [DisplayName("Title")]
        public string GameName { get; set; }

        [DisplayName("Published By")]
        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }

        public string CoverArt { get; set; }

        [DisplayName("Discription")]
        public Guid? DescriptionId { get; set; }
        public DescriptionViewModel Description { get; set; } 

        [DisplayName("Rating")]
        public float Rate { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Released")]
        public string Release { get; set; }

        [DisplayName("Download here")]
        public string DownloadLink { get; set; }

        [DisplayName("Try the demo")]
        public string DemoLink { get; set; }

        [DisplayName("Downloaded")]
        public int NumOfDownloads { get; set; }
        public DateTime Publish { get; set; }
        public int State { get; set; }
        public int ReleaseState { get; set; }

        public IEnumerable<CommentViewModel> Comments { get; set; }
        public IEnumerable<MediaViewModel> Medias { get; set; }
        public Guid MinSysReqId { get; set; }
        public Guid RecSysReqId { get; set; }
        public SysReqViewModel MinSysReq { get; set; }
        public SysReqViewModel RecSysReq { get; set; }
        public string SysReqNotes { get; set; }
        public ICollection<GamePropertyViewModel> Genres { get; set; }
        public bool owned { get; set; }
        public bool MyDevelopment { get; set; }
    }
}