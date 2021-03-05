using MadamSolution.Application.System.Roles;
using MadamSolution.Data.EF;
using MadamSolution.Data.Entities;
using MadamSolution.ViewModels.System.Roles;
using MadamSolution.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadamSolution.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly MadamDbContext _context;

        public SlideService(MadamDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}