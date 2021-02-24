using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Game
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CoverArt { get; set; }
        public double Rate { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
        public string DownloadLink { get; set; }
        public string DemoLink { get; set; }
        public int NumOfDownloads { get; set; }

        public Guid? MinSysReqId { get; set; }
        public SysReq MinSysReq { get; set; }
        public Guid? RecSysReqId { get; set; }
        public SysReq RecSysReq { get; set; }
        public string SysReqNotes { get; set; }
        public DateTime Publish { get; set; }
        public int State { get; set; } //0: unpublished, 1: published, 2: pending approval, 3: denied, 4: deleted
        public int ReleaseState { get; set; } //0: normal, 1: early access, 2: beta

        public ICollection<Comment> Comments { get; set; }
        public virtual ICollection<UserGames> UserGames { get; set; }
        public ICollection<Media> Medias { get; set; }

        //[ForeignKey("GameId")]
        public ICollection<GameProperty> Genres { get; set; }
        public ICollection<Description> Descriptions { get; set; } 
    }
}
