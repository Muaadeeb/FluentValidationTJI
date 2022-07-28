using AutoMapper;
using FluentValidationTJI.DbContexts;
using FluentValidationTJI.Managers.Interfaces;
using FluentValidationTJI.Models;
using FluentValidationTJI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationTJI.Managers
{
    public class AlphaManager : IAlphaManager
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AlphaManager(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AlphaDto>> GetAsync()
        {
            return _mapper.Map<IEnumerable<Alpha>, IEnumerable<AlphaDto>>(await _context.Alphas.ToListAsync());
        }

        public async Task<AlphaDto> GetByIdAsync(int id)
        {
            var alpha = await _context.Alphas.SingleOrDefaultAsync(x => x.Id == id);
            if (alpha is null)
            {
                return new();
            }

            return _mapper.Map<Alpha, AlphaDto>(alpha);
        }

        public async Task<AlphaDto> CreateAsync(AlphaDto obj)
        {
            var alpha = _mapper.Map<AlphaDto, Alpha>(obj);
            var addedAlpha = await _context.Alphas.AddAsync(alpha);

            await _context.SaveChangesAsync();
            return _mapper.Map<Alpha, AlphaDto>(addedAlpha.Entity);
        }

        public async Task<AlphaDto> UpdateAsync(AlphaDto obj)
        {
            var alphaDetails = await _context.Alphas.FindAsync(obj.Id);
            var alpha = _mapper.Map<AlphaDto, Alpha>(obj, alphaDetails!);

            var updatedAlpha = _context.Alphas.Update(alpha);
            await _context.SaveChangesAsync();
            return _mapper.Map<Alpha, AlphaDto>(updatedAlpha.Entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            var alphaDetails = await _context.Alphas.FindAsync(id);
            if (alphaDetails is not null)
            {
                _context.Alphas.Remove(alphaDetails);
                return await _context.SaveChangesAsync();
            }

            return 0;
        }
    }
}
