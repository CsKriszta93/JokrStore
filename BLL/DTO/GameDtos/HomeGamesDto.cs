using System.Collections.Generic;

namespace BLL.DTO
{
    public class HomeGamesDto
    {
        public IEnumerable<GameDtoLite> NewReleases { get; set; }
        public IEnumerable<GameDtoLite> NewTests { get; set; }
    }
}
