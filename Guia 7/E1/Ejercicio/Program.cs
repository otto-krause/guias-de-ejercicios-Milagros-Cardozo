using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Crear el objeto SpiderTeam, que conoce a todos los Spidermans
            //Crear el método PelearConKingpin, que hace que todos los Spidermans ataquen a Kingpin.
            //Crear el método volver a casa, en el cual si Kingpin fue vencido hace que el Spiderman más débil (menor poder) regrese a su casa (Quitarlo del SpiderTeam). Si Kingpin no fue vencido el programa lanzará un error.
            //Se desea conocer la fuerza del SpiderTeam, esto se calcula como la sumatoria de las fuerzas de los integrantes del equipo.
            //Spiderman Clasico
            //Sabemos que todos los Spiderman tienen un traje y también conocemos su fuerza, además conocen el mensaje atacar en el cuál le bajan tanta vida a Kingpin como poder posea el Spiderman.
            //Peter Parker
            //Su poder se calcula como su fuerza más la resistencia de su traje.
            //Spiderman Noir
            //Su poder se calcula como el poder de Peter Parker, pero al cálculo le suma la cantidad de armas que posee su traje. Cada arma tiene una marca y una cantidad de balas.
            //Spider Gwen
            //Su poder se calcula como su fuerza más su glamour (número que debe valer entre 1 y 10, sino lanzará error).
            //Miles morales
            //Su poder se calcula como su fuerza más su habilidad para cantar.
            //Kingpin
            //Inicialmente tiene 800 puntos de vida y sabemos que fueVencido si sus puntos de vida son menores a cero.

        }
    }
}
