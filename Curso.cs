using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaORM
{
    class Curso
    {
        public int CursoId { get; set; }
        public string nombre { get; set; }
        public Guid profesorId { get; set; }
        public Profesor profesorNavigator { get; set; }
        public ICollection<Estudiante> EstudiantesNavigator { get; set; }


    }
}
