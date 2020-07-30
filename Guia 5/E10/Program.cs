using System;

//Un colegio realiza reuniones de ex compañeros de secundaria, de los cuales quiere recolectar información. 
//Los compañeros son:
//Políglotas: cuando hablan más de 5 idiomas.
//Bilingües: hablan al menos 2 idiomas.
//Exitosos: cuando ganan más de 200000 al mes.
//Viajeros: cuando visitaron más de 4 países.
//El colegio quiere saber si el curso fueExitoso, esto sucede cuando más de 5 exalumnos 
//son exitosos, más de 3 son viajeros, todos son bilingües y hay por lo menos un políglota.


namespace E10
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();

            Console.WriteLine("El curso fue exitoso? " + curso.fueExitoso());
        }
    }
}
