using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class Curso
    {
        public int CursoId { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Descricao { get; set; }

        public List<Aluno> Aluno { get; set; }

        public List<CursoDisciplina> CursosDisciplinas { get; set; }

        public List<Grade> Grade { get; set; }
    }
}
