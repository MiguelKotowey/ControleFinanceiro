using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Data.DTOs
{
    public class TipoDespesaDTO
    {
        public record TipoDespesa(int Id, string? Descricao, bool Ativo);
        public record CreateTipoDespesaDTO(string? Descricao);
        public record UpdateTipoDespesaDTO(string? Descricao, bool Ativo);
    }
}
