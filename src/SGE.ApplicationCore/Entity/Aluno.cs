using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int CursoId { get; set; }

        public Curso Curso { get; set; }

        public Endereco Endereco { get; set; }





    }
}
