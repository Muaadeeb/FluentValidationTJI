using FluentValidationTJI.Models.Dto;

namespace FluentValidationTJI.Managers.Interfaces
{
    public interface IAlphaManager
    {
        Task<IEnumerable<AlphaDto>> GetAsync();

        Task<AlphaDto> GetByIdAsync(int id);

        Task<AlphaDto> CreateAsync(AlphaDto obj);

        Task<AlphaDto> UpdateAsync(AlphaDto obj);

        Task<int> DeleteAsync(int id);
    }
}
