using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoRegistroEstudiantes.Entities
{
    public class EstudianteMateria
    {
        public Materia Materia { get;set;} = null!;
        public Estudiante Estudiante { get;set;}= null!;
    }
}