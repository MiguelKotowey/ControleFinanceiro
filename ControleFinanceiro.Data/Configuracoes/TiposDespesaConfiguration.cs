using ControleFinanceiro.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Data.Configuracoes
{
    public class TiposDespesaConfiguration : IEntityTypeConfiguration<TipoDespesa>
    {
        public void Configure(EntityTypeBuilder<TipoDespesa> builder)
        {
            builder.ToTable("TiposDespesa");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Descricao).HasMaxLength(500);

            builder.Property(t => t.DataCriacao).IsRequired();

            builder.Property(t => t.Ativo).IsRequired();

            // Configurações para PostgreSQL
            builder.Property(t => t.Id).UseIdentityColumn();
        }
    }
}
