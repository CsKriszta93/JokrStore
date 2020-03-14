using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class GameDto
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set; }
        public string CoverArt { get; set; }
        public Guid? DescriptionId { get; set; }
        public DescriptionDto Description { get; set; } 
        public double Rate { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
        public string DownloadLink { get; set; }
        public string DemoLink { get; set; }
        public int NumOfDownloads { get; set; }
        public DateTime Publish { get; set; }
        public int State { get; set; }
        public int ReleaseState { get; set; }

        public Guid? MinSysReqId { get; set; }
        public SysReqDto MinSysReq { get; set; }
        public Guid? RecSysReqId { get; set; }
        public SysReqDto RecSysReq { get; set; }
        public string SysReqNotes { get; set; }

        public ICollection<CommentDto> Comments { get; set; }
        public ICollection<MediaDto> Medias { get; set; }
        public ICollection<GamePropertyDto> Genres { get; set; }
    }
}
