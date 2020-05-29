using System;

namespace BLL.DTO
{
    public class GameDtoLite
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public string CoverArt { get; set; }
    }
}
