using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinica clinica = new Clinica();
            string especialidad;
            Console.WriteLine("Ingrese la especialidad:");
            especialidad = Console.ReadLine();
            clinica.Consulta(especialidad);
        }
    }
}
