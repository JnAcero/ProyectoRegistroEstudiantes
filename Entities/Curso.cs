using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoRegistroEstudiantes.Entities
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; } = null!;
        public ICollection<Estudiante> Estudiantes{get; set; } = new List<Estudiante>();

        public ICollection<Materia> Materias { get; set; } = new List<Materia>();
        
    }
}