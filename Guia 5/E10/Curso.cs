using System.Collections.Generic;
using System.Linq;

namespace E10
{
    public class Curso
    {
        List <ExAlumnos> alumnos = new List<ExAlumnos>();
        public Curso()
        {
            alumnos.Add(new ExAlumnos("Camila", 4, 230000, 4));
            alumnos.Add(new ExAlumnos("Milagros", 2, 220000, 5));
            alumnos.Add(new ExAlumnos("Rodrigo", 3, 120000,3));
            alumnos.Add(new ExAlumnos("Pepita", 3, 300000, 6));
            alumnos.Add(new ExAlumnos("Karenina", 7, 250000, 3));
            alumnos.Add(new ExAlumnos("Ayelen", 2, 200500, 4));
        }
        public bool fueExitoso()
        {
            return alumnos.Where(alumno => alumno.Sueldo > 200000).ToList().Count() >= 5
            && alumnos.Where(alumno => alumno.Viajes >= 4).ToList().Count() >= 4
            && alumnos.All(alumno => alumno.Idiomas >= 2) 
            && alumnos.Any(alumno => alumno.Idiomas > 5);
        }
    }
}