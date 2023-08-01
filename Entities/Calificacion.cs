using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoRegistroEstudiantes.Entities
{
    public class Calificacion
    {
        public double Nota { get; set; }
        public Estudiante Estudiante { get; set; } = null!;
        public Materia Materia { get; set; } = null!;
        public DateOnly FechaRegistro { get; set; }
        
    }
}