using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoRegistroEstudiantes.Entities;

namespace ProyectoRegistroEstudiantes.DTOS
{
    public class MateriaDto
    {
        public int Id { get; set; }
        public string NombreMateria { get; set; }= null!;
        public ICollection<Calificacion> Notas { get; set; } = new List<Calificacion>();
    }
}