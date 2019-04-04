using System;
using System.Collections.Generic;

namespace JOKRStore.ViewModels
{
    public class GameViewModel
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public string Developer { get; set; }
        public string CoverArt { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }
        public decimal Price { get; set; }
        public DateTime Release { get; set; }
        public string DownloadLink { get; set; }
        public string DemoLink { get; set; }
        public int NumOfDownloads { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
