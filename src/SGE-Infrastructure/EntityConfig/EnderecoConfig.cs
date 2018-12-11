using Microsoft.EntityFrameworkCore;
using SGE.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE_Infrastructure.EntityConfig
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(x => x.Logradouro)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.CEP)
                .HasColumnType("varchar(9)");

            builder.Property(x => x.Numero)
                .HasColumnType("varchar(100)");
        }
    }
}
