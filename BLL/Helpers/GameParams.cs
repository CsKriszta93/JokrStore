namespace BLL.Helpers
{
    public class GameParams
    {
        private const int MaxPageSize = 100;
        public int CurrentPage { get; set; }
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

    }
}