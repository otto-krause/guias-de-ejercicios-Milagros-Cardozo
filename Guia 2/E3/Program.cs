using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Album albu = new Album();
            int opcion=1;
            string nomb;
            string pais;
            string posi;
            int figu;
            do
            {
                Console.WriteLine("Que desea saber?\n[1]Cuantos delanteros hay\n[2]Cuantos medioscampo hay\n[3]Ingresar una nueva figurita");
                opcion = Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    Console.WriteLine(albu.CuantosX("Delantero"));
                }
                if(opcion==2)
                {
                    Console.WriteLine(albu.CuantosX("Mediocampista"));
                }
                if(opcion==3)
                {
                    Console.WriteLine("Ingrese nombre, pais, posicion y numero de la figurita");
                    nomb=Console.ReadLine();
                    pais=Console.ReadLine();
                    posi=Console.ReadLine();
                    figu= Int32.Parse(Console.ReadLine());
                    Console.WriteLine(albu.lista(nomb,pais,posi,figu));
                }
                Console.WriteLine(albu.albumLleno());
            }
            while(opcion!=0);            
        }
    }
}
