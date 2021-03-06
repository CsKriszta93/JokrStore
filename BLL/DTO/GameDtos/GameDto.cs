﻿using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class GameDto
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public Guid UserId { get; set; }
        public UserDtoLite User { get; set; }
        public string CoverArt { get; set; }
        public double Rate { get; set; }
        public decimal Price { get; set; }
        public string Release { get; set; }
        public string DownloadLink { get; set; }
        public string DemoLink { get; set; }
        public int NumOfDownloads { get; set; }
        public string Publish { get; set; }
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
        public ICollection<DescriptionDto> Descriptions { get; set; } 
    }
}
