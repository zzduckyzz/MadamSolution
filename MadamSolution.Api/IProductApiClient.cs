using MadamSolution.ViewModels.Catalog.Products;
using MadamSolution.ViewModels.Common;
using MadamSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamSolution.Api
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<bool> UpdateProduct(ProductUpdateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductVm> GetById(int id, string languageId);

        Task<List<ProductVm>> GetFeaturedProducts(string languageId, int take);

        Task<List<ProductVm>> GetLatestProducts(string languageId, int take);
    }
}