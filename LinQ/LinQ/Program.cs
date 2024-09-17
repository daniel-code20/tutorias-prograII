using System;
using System.Collections.Generic;
using System.Linq;

namespace MiNuevoPrograma
{
    class Estudiante
    {
        public string Nombre { get; set; }

        public int Calificacion { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Descripción: Crea una clase Estudiante, luego usa LINQ para filtrar
            //estudiantes con una calificación mayor a 85 y ordénalos por su nombre.

            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante {Nombre = "Mauricio", Calificacion = 90},
                new Estudiante {Nombre = "Luis", Calificacion = 88},
                new Estudiante {Nombre = "Bryan", Calificacion = 84},
                new Estudiante {Nombre = "Ivan", Calificacion = 70},
            };

            /*var estudianteFiltrados = estudiantes.Where(e => e.Calificacion < 85)
                .OrderBy(e => e.Nombre);*/

            var estudianteFiltrados = from e in estudiantes
                                      where e.Calificacion < 85
                                      orderby e.Nombre
                                      select e;

            Console.WriteLine("Estudiantes con nota mayor a 85");

            foreach (var item in estudianteFiltrados)
            {
                Console.WriteLine($"{item.Nombre}: {item.Calificacion}");
            }

        }
    }
}
