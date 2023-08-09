
namespace ProyectoRegistroEstudiantes.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Edad { get; set; }
        public Curso Curso { get; set; }  = null!;
        public ICollection<Calificacion> Calificaciones { get; set; } = new List<Calificacion>();
        public ICollection<EstudianteMateria> MateriasEstudiantes { get; set; } = new List<EstudianteMateria>();
      
    }
}