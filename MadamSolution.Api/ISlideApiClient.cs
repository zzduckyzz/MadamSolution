using MadamSolution.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MadamSolution.Api
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}