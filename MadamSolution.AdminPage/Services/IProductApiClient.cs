using MadamSolution.ViewModels.Catalog.Products;
using MadamSolution.ViewModels.Common;
using MadamSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamSolution.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);
    }
}