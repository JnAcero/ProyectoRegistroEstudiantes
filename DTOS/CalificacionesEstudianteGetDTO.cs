using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoRegistroEstudiantes.DTOS
{
    public class CalificacionesEstudianteGetDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public ICollection<MateriaDto> Materias { get; set; }=new List<MateriaDto>();
        
    }
}