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
        public string Description { get; set; }
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

        public List<Comment> Comments { get; set; }
        public List<UserGames> UserGames { get; set; }
        public List<Media> Medias { get; set; }

        //[ForeignKey("GameId")]
        public List<GameProperty> Genres { get; set; }
    }
}
