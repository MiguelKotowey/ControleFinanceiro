using ControleFinanceiro.Core.DTOs;

namespace ControleFinanceiro.Web.Services
{
    public interface ITipoDespesaService
    {
        Task<IEnumerable<TipoDespesaDTO>> GetAllAsync();
        Task<TipoDespesaDTO?> GetByIdAsync(int id);
        Task<TipoDespesaDTO> CreateAsync(CreateTipoDespesaDTO dto);
        Task UpdateAsync(int id, UpdateTipoDespesaDTO dto);
        Task DeleteAsync(int id);
        Task<IEnumerable<TipoDespesaDTO>> GetAtivosAsync();
    }
}
