using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Data.DTOs
{
    public class TiposDespesaDTO
    {
        public record TipoDespesaDTO(int Id, string Nome, string? Descricao, bool Ativo);
        public record CreateTipoDespesaDTO(string Nome, string? Descricao);
        public record UpdateTipoDespesaDTO(string Nome, string? Descricao, bool Ativo);
    }
}
