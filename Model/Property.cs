using System;
using System.Collections.Generic;

namespace Model
{
    public class Property
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        /*
        0: Genre
        1: Game mode
        2: Language
        3: Violation contents
         */
        public IEnumerable<GameProperty> GameProperties { get; set; }
    }
}