using System;

namespace E7
{
    public class camaras
    {
        int resmega=0,cantifoto=0,peso=0;
        public int pesoPorfoto()
        {
            Console.WriteLine("¿cuantos megapixeles tiene la foto?");
            resmega=Int32.Parse(Console.ReadLine());
            peso=resmega*3;
            Console.WriteLine("El peso de la foto es: {0} MB",peso);
            cantifoto++;
            return peso;
        }
        public void PesoTotalDeFotos(int total)
        {
            Console.WriteLine("El total es: {0} MB",total);
        }
    }
}