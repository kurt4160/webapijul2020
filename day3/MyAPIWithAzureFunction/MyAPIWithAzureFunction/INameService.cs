using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyAPIWithAzureFunction
{
    public interface INameService
    {
        Task<string> GetNameAsync(HttpRequest req);
    }
}