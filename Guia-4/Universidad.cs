using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    public partial class Universidad
    {
        //Lista de alumnos
       private List <Alumno>  ListaAlumnos;

        //Constructor para inicializar la lista de alumnos
        public Universidad()
        {
            ListaAlumnos = new List<Alumno>();
        }

        //Metodo estatico para agregar un alumno a la lista
        public void AgregarAlumno(Alumno alumno)
        {
            ListaAlumnos.Add(alumno);
        }

        //Metodo estatico para mostrar a detalle la lista
        public List<Alumno> ObtenerListaAlumno()
        {
            return ListaAlumnos;
        }
    }
}
