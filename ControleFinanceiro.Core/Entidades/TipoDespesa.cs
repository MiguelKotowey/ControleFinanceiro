using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Core.Entidades
{
    public class TipoDespesa
    {
        public int Id { get; private set; }
        [Required]
        public string? Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public bool Ativo { get; private set; }

        // Construtor privado para EF
        private TipoDespesa() { }

        public TipoDespesa(string nome, string? descricao = null)
        {
        Descricao = descricao;
            DataCriacao = DateTime.UtcNow;
            Ativo = true;
        }

        // Métodos para alterar propriedades
        public void Atualizar(string nome, string? descricao)
        {
            Descricao = descricao;
        }

        public void Desativar()
        {
            Ativo = false;
        }

        public void Ativar()
        {
            Ativo = true;
        }
    }
}
