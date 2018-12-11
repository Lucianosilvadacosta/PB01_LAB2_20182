using Microsoft.EntityFrameworkCore;
using SGE.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE_Infrastructure.EntityConfig
{
    public class DisciplinaConfig : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Disciplina> builder)
        {
            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(100)");
        }
    }
}
