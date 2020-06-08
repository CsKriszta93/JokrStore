using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace BLL.Helpers
{
    public static class Extensions {
        public static void AddApplicationError(this HttpResponse response, string messages) {
            response.Headers.Add("Application-Error", messages);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static void AddPagination(this HttpResponse response,
            int currentPage, int itemsPerPage, int totalItems, int totalPages) {
            
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}