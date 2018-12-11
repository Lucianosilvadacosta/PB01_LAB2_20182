using Microsoft.EntityFrameworkCore;
using SGE.ApplicationCore.Entity;
using SGE_Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE_Infrastructure.Data
{
   public class SGEContext : DbContext
    {


        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<CursoDisciplina> CursosDisciplinas { get; set; }

        public DbSet<Disciplina> Disciplinas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdSGE;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfig());
            modelBuilder.ApplyConfiguration(new CursoConfig());
            modelBuilder.ApplyConfiguration(new DisciplinaConfig());
            modelBuilder.ApplyConfiguration(new EnderecoConfig());
            modelBuilder.ApplyConfiguration(new GradeConfig());


            #region Propagação de dados das entidades

            modelBuilder.Entity<Aluno>()
                .HasData(
                
                
                new Aluno { AlunoId =1, Nome = "Luciano", Email = "luciano.costa@gmail.com", CursoId = 1}

                
                );
            modelBuilder.Entity<Curso>()
                .HasData(


                new Curso { CursoId = 1, Descricao = "DST" }


                );

            modelBuilder.Entity<Disciplina>()
                .HasData(


                new Disciplina { DisciplinaId = 1, Descricao = "Desenvolvedor ......."}


                );

            modelBuilder.Entity<Grade>()
                .HasData(


                new Grade { GradeId = 1, Descricao = "jahajjhh", CursoId = 1}


                );

            modelBuilder.Entity<Endereco>()
                .HasData(


                new Endereco { EnderecoId = 1, Logradouro = "Rua", Bairro = "Tres Barras", CEP = "78058-549", Numero = "29", AlunoId = 1 }


                );

            modelBuilder.Entity<CursoDisciplina>()
                .HasData(


                new CursoDisciplina { Id = 1, CursoId = 1, DisciplinaId = 1}


                );

            #endregion


        }

    }
}
