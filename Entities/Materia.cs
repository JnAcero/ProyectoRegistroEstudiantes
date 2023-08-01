using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoRegistroEstudiantes.Entities
{
    public class Materia
    {
        public int Id { get; set; }
        public string NombreMateria { get; set; }= null!;
        public ICollection<Calificacion> Notas { get; set; } = new List<Calificacion>();
        public ICollection<EstudianteMateria> MateriasEstudiantes { get; set; } = new List<EstudianteMateria>();

    }
}