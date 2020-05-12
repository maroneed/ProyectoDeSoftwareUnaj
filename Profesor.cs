using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaORM
{
    class Profesor
    {
        public int profesorID { get; set; }
        public string nombre { get; set; }
        public decimal sueldo { get; set; }
        public ICollection<Curso> CursoNavigator { get; set; }

    }
}
