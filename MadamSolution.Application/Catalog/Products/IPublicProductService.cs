using MadamSolution.ViewModels.Catalog.Products;
using MadamSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MadamSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}
