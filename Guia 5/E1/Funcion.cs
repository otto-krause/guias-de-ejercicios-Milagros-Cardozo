using System;
using System.Linq;
using System.Collections.Generic;

namespace E1
{
    public class Funcion
    {
        List<Persona> personas = new List<Persona> { new Persona("Juan", "Perez", 34), new Persona ("Maria", "Perez", 23), new Persona("Lucas", "Torres", 12) };
        void MayoresDeEdad()
        {
            Console.WriteLine("Mayores de edad: ");
            personas.Where(persona => persona.Edad >= 18)
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre));
        }
        void SoloJuan()
        {
            Console.WriteLine("Todas las personas que se llaman Juan: ");
            personas.Where(persona => persona.Nombre == "Juan")
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre, persona.Apellido));
        }
        void CantidadDePerez()
        {
            int cantidadPerez = personas.Count(persona => persona.Apellido == "Perez");
            Console.WriteLine("La cantidad de Perez es: " + cantidadPerez);
        }
    }
}