using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.ApplicationCore.Entity
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }

        public string Descricao { get; set; }

        public int CargaHoraria { get; set; }

        public List<CursoDisciplina> CursosDisciplinas { get; set; }


    }
}
