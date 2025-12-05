using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Core.DTOs
{
    public class TipoDespesaDTO
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }
    }

    public class CreateTipoDespesaDTO
    {
        public string? Descricao { get; set; }
    }

    public class UpdateTipoDespesaDTO
    {
        public string? Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
