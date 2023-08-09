using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoRegistroEstudiantes.DTOS;
using ProyectoRegistroEstudiantes.Entities;

namespace ProyectoRegistroEstudiantes.Services.EstudianteService
{
    public class EstudianteService : IEstudianteService
    {
        public Estudiante CrearEstudiante(int id, string nombre, string apellido, int edad, Curso curso)
        {
            var estudiante = new Estudiante()
            {
                Id = id,
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                Curso = curso
            };
            return estudiante;
        }
        public object GetCursoEstudiante(Estudiante estudiante)
        {
            return new EstudianteGetCursoDTO()
            {
                ID = estudiante.Id,
                Nombre = estudiante.Nombre,
                Curso = estudiante.Curso
            };
        }
        public CalificacionesEstudianteGetDTO GetCalificaciones(Estudiante estudiante)
        {
            List<MateriaDto> materiasDto=new();
            
            var materias = estudiante.Curso.Materias;
            foreach (var materia in materias)
            {
                materiasDto.Add(new MateriaDto{
                    Id= materia.Id,
                    NombreMateria = materia.NombreMateria,
                    Notas = materia.Notas
                });  
            }
            return new CalificacionesEstudianteGetDTO
            {
                Id = estudiante.Id,
                Nombre = estudiante.Nombre,
                Materias = materiasDto
            };
            
        }
    }
}