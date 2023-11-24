using System.Text.Json;
using API.RequestHelpers;

namespace API.Extensions
{
    public static class HttpExtensions
    {
        const string cPagination = "Pagination";
        public static void AddPaginationHeader(this HttpResponse response, MetaData metaData)
        {
            var options = new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
            response.Headers.Append(cPagination, JsonSerializer.Serialize(metaData, options));
            response.Headers.Append("Access-Control-Expose-Headers", cPagination);
        }
    }
}