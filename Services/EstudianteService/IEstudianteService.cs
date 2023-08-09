using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoRegistroEstudiantes.DTOS;
using ProyectoRegistroEstudiantes.Entities;

namespace ProyectoRegistroEstudiantes.Services.EstudianteService
{
    public interface IEstudianteService
    {
        Estudiante CrearEstudiante(int Id, string nombre,string apellido,int edad,Curso curso);
        object GetCursoEstudiante(Estudiante estudiante);
        CalificacionesEstudianteGetDTO GetCalificaciones(Estudiante estudiante);
    }
}