using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGE.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE_Infrastructure.EntityConfig
{
    public class CursoConfig : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(100)");
        }
    }
}
