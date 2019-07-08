using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Media
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public Game game { get; set; }
        public int type { get; set; }
        public string contain { get; set; }
    }
}
