namespace Guia_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"********************************************************************");
            Console.WriteLine($"Bienvenidos a nuestra universidad, esperamos se sientan como en casa");
            Console.WriteLine($"********************************************************************");

            //Instanciando la clase universidad
            Universidad uni = new Universidad();

            //Agregando alumnos a la lista
            Alumno alumno1 = new Alumno("Martin Ñelias", 19, Carreras.Ingenieria_de_Sistemas, "2023-0312U");
            alumno1.Calificaciones.AddRange(new List<double> { 67, 45 });

            Alumno alumno2 = new Alumno("Michael Ñuiz", 35, Carreras.Ingenieria_de_Sistemas, "2012-0212U");
            alumno2.Calificaciones.AddRange(new List<double> { 79, 65 });

            Alumno alumno3 = new Alumno("Jose Manchado", 18, Carreras.Ingenieria_Electronica, "2023-0514U");
            alumno3.Calificaciones.AddRange(new List<double> { 45, 67 });

            Alumno alumno4 = new Alumno("Elvis Del Monte", 25, Carreras.Ingenieria_en_Computacion, "2022-0317U");
            alumno4.Calificaciones.AddRange(new List<double> { 64, 59 });

            Alumno alumno5 = new Alumno("Paychell Martinez", 20, Carreras.Telecomunicaciones, "2021-0932U");
            alumno5.Calificaciones.AddRange(new List<double> { 98, 34 });

            //Agregando alumnos a la universidad
            uni.AgregarAlumno(alumno1);
            uni.AgregarAlumno(alumno2);
            uni.AgregarAlumno(alumno3);
            uni.AgregarAlumno(alumno4);
            uni.AgregarAlumno(alumno5);
            //Obteniendo la lista de alumnos
            List<Alumno> alumnos = uni.ObtenerListaAlumno();


            foreach(Alumno alumno in alumnos)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}, Carrera: {alumno.Carrera}, Carnet: {alumno.Carnet}");
               
                Console.Write($"Calificaciones: ");
                int Contador = 1;
                foreach (double Calificacion in alumno.Calificaciones)
                {
                    Console.Write(Calificacion);
                    if (Contador < alumno.Calificaciones.Count)
                    {
                        Console.WriteLine("");
                    }

                    Contador++;
                }

                    Console.WriteLine();
                    Console.WriteLine($"Promedio: " + alumno.CalcularPromedioCalificaciones());
                    Console.WriteLine($"Estado de aprobacion: " + alumno.EstadoAprobacion());
                    Console.WriteLine("\n");
            }
        }

    }
}