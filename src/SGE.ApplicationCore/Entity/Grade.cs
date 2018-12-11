using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class Grade
    {
        public int GradeId { get; set; }

        public string Descricao { get; set; }

        public int CursoId { get; set; }

        public Curso Curso { get; set; }

        

    }
}
