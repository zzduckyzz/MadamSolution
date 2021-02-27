using MadamSolution.ViewModels.Common;
using MadamSolution.ViewModels.System.Languages;
using MadamSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadamSolution.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}