using System;

namespace BLL.DTO.GameDtos
{
    public class CartGameDto
    {
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public string CoverArt { get; set; }
        public decimal Price { get; set; }
    }
}