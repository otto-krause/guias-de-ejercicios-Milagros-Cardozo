using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
         static void Main(string[] args)
        {
            Clinica clini = new Clinica();
            int opcion=1;
            string especialidad;
            do
            {
                Console.WriteLine("Especialidades:\nNeurologia\nTraumatologia\nPsiquiatria\nCardiologia\nRaumotologia\nRadiologia");
                Console.WriteLine("Ingrese la especialidad de medicina para asignarle un turno\n");
                especialidad = Console.ReadLine();
                clini.especi(especialidad);
                Console.WriteLine("Quiere ver otro turno?\n [1]Si\n [2]No\n");
                opcion = Int32.Parse(Console.ReadLine());
            }
            while(opcion==1);
        }
    }
}