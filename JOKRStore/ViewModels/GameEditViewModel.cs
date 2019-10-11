using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels
{
    public class GameEditViewModel
    {
        public GameViewModel Game { get; set; }
        public PropertyViewModel [] Genres { get; set; }
        public PropertyViewModel [] GameModes { get; set; }
    }
}