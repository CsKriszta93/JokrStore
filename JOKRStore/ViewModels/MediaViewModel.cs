using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOKRStore.Web.ViewModels
{
    public class MediaViewModel
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public int type { get; set; }
        public string contain { get; set; }
    }
}