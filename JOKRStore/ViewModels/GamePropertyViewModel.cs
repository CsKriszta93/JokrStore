using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels
{
    public class GamePropertyViewModel
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public GameViewModel Game { get; set; }
        public Guid PropertyId { get; set; }
        public PropertyViewModel Property { get; set; }

    }
}