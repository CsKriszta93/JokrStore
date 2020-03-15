using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace JOKRStore.Web.ViewModels
{
    public class GameIndexViewModel
    {
        public IEnumerable<GameViewModel> new_release { get; set; }
        public IEnumerable<GameViewModel> new_tests { get; set; }
    }
}