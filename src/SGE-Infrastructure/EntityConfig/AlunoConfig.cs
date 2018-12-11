using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGE.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE_Infrastructure.EntityConfig
{
    public class AlunoConfig : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)");
        }
    }
}
