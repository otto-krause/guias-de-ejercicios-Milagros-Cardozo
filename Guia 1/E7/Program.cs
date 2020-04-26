using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0,total=0,opcion1=1;
            Celular celu= new Celular (true,true);
            camaras camaras=new camaras();
            do
            {
                Console.WriteLine("1)saber peso de la foto\n2)saber el total de todas\n3)Memoria\n4)NFC");
                opcion=Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    total=total+camaras.pesoPorfoto();
                }
                if(opcion==2)
                {
                    camaras.PesoTotalDeFotos(total);
                }
                if(opcion==3)
                {
                    celu.MemoriaDisponible(total);
                }
                if(opcion==4)
                {
                    Console.WriteLine("¿Tiene NFC?"+celu.TeCargaLaSUBE());
                }
                Console.WriteLine("¿quiere seguir usando su celular?\n1)Si\n2)No");
                opcion1=Int32.Parse(Console.ReadLine());
            }while(opcion1==1);
        }
    }
}