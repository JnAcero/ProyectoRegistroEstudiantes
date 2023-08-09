using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoRegistroEstudiantes.Entities;

namespace ProyectoRegistroEstudiantes.Services.CursoService
{
    public class CursoService:ICursoService
    {
        public Curso CrearCurso(int id, string nombre)
        {
            return new Curso(){
                IdCurso = id,
                Nombre = nombre 
            };
        }
        public void AsignarMaterias(Curso curso,List<Materia> materias)
        {
            curso.Materias=materias;
        }
        public ICollection<Estudiante> GetEstudiantes(Curso curso)
        {
            
            return curso.Estudiantes; 
        }
        
    }
}