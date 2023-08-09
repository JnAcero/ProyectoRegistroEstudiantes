using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoRegistroEstudiantes.Entities;

namespace ProyectoRegistroEstudiantes.DTOS
{
    public class EstudianteGetCursoDTO
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public Curso Curso { get; set; }=null!;
    }
}