using System;

namespace E4
    {
    
        class program
    
        {
            static void Main(string[] args)
            {
                int opcion = 0,juega=0,opcion1=1;
                Gatito domino=new Gatito("domino",true,45);
                do
                {
                    Console.WriteLine("Que desea saber del gatito? \n[1] Para saber el nombre \n[2] Para saber si esta vacunado \n[3] Cuanta energia le queda despues de jugar \n[4] Para recargar energia \n[5] Para saber si el gatito esta saludable");
                    opcion = Int32.Parse(Console.ReadLine());
                    if(opcion == 1)
                    {
                        Console.WriteLine("El nombre del gatito es "+domino.nombreGatito()); 
                    }
                    if(opcion == 2)
                    {
                        Console.WriteLine("El gato esta vacunado? "+domino.estaVacunado());
                    }
                    if(opcion == 3)
                    {
                        Console.WriteLine("ingrese los minutos de juego: ");
                        juega=Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El gato tiene energia de: "+domino.cuantoJuega(juega));
                    }
                    if(opcion == 4)
                    {
                        Console.WriteLine("La energia actual del gatito es: "+domino.Comer());
                    }
                    if(opcion == 5)
                    {
                        Console.WriteLine("El gatito esta saludable? "+domino.estaSaludable());
                    }
                    Console.WriteLine("¿Quiere realizar otra operacion?\n1)Si\n2)No");
                    opcion1=Int32.Parse(Console.ReadLine());
                }
                while(opcion1==1);
            }
        }

    }
