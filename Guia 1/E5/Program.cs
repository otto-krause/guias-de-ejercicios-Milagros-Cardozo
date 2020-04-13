using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1=0,lado2=0,lado3=0,teorema1=0,teorema2=0,teorema3=0,opcion=0,opcion1=0,objeto=0,lados=0,tria=0,estrar=0;
            Triangulo trian=new Triangulo();
            do
            {
                Console.WriteLine("[1]Ingresar los lados \n[2]Crear los objetos \n[3]Ver los mensajes\n");
                opcion=Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    Console.WriteLine("Ingrese el lado 1 del triangulo");
                    lado1=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el lado 2 del triangulo");
                    lado2=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el lado 3 del triangulo");
                    lado3=Int32.Parse(Console.ReadLine());
                    lados=1;
                }
                if(opcion==2)
                {
                    if(lados==1)
                    {
                        if(lado1==lado2&&lado2==lado3)
                        {
                            tria=1;
                        }
                        if(lado1==lado2&&lado2!=lado3)
                        {
                            tria=2;
                        }
                        if(lado1!=lado2&&lado2!=lado3)
                        {
                            tria=3;
                        }
                        teorema1=lado1*lado1;
                        teorema2=lado2*lado2;
                        teorema3=lado3*lado3;
                        if(teorema1+teorema2==teorema3)
                        {
                            estrar=1;
                        }
                        objeto=1;
                    }
                    else
                    {
                        Console.WriteLine("Primero tiene que ingresar los lados\n");
                    }
                }
                if(opcion==3)
                {
                    if(objeto==1)
                    {
                        Console.WriteLine("¿El triangulo es escaleno?:"+trian.EsEscaleno(tria));
                        Console.WriteLine("¿El triangulo es isosceles?:"+trian.EsIsosceles(tria));
                        Console.WriteLine("¿El triangulo es equilatero?:"+trian.EsEquilatero(tria));
                        Console.WriteLine("¿El triangulo es un Triangulo Rectangulo?:"+trian.EsTrianguloRectangulo(estrar));
                    }
                    else
                    {
                        Console.WriteLine("Primero tiene que crear el objeto\n");
                    }
                }
                Console.WriteLine("¿Quiere realizar otra operacion?\n[1]Si\n[2]No");
                opcion1=Int32.Parse(Console.ReadLine());
            }while(opcion1==1);
        }
    }
}
