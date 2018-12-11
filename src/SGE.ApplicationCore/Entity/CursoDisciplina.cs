using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class CursoDisciplina
    {
        public int Id { get; set; }

        public Curso Curso { get; set; }

        public int CursoId { get; set; }

        public Disciplina Disciplina { get; set; }

        public int DisciplinaId { get; set; }




    }
}
