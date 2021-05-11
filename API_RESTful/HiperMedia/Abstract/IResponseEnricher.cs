using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;


namespace API_RESTful.HiperMedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
