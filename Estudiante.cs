using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaORM
{
    class Estudiante
    {
        public int EstudianteId { get; set; }
        public string nombre { get; set; }

        public Guid cursoId { get; set; }
        public Curso cursoNavigator { get; set; } 
    }
}
