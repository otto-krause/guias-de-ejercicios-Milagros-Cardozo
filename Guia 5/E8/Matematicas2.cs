using System;
using System.Linq;
using System.Collections.Generic;

namespace E8
{
    public class Matematicas2
    {
        public List <int> ParYDistinto(List<int> numeros, int opcion)
        {
            List<int> resu = new List<int>();
            switch (opcion)
            {
                case 2:
                    resu = numeros.Where(numero => numero%2 == 0).ToList();
                break;
                case 3:
                    resu = numeros.Distinct().ToList();
                break;
            }
            return resu;
        }
        public int SumaPrimos(List<int> numeros)
        {
            int aux = 0;
            List<int> primos = new List<int>();
            foreach (var i in numeros)
            {
                for (int x = 1; x<(i+1); x++)
                {
                    if(i%x == 0)
                    {
                        aux++;
                    }
                }
                switch (aux)
                {
                    case 2:
                        primos.Add(i);
                    break;
                }
                aux = 0;
            }
            return primos.Sum();
        }
        public List<int> Primos(List<int> numeros, int opcion)
        {
            return numeros.Where(numero => EsPrimo(numero)).ToList();
        }
        private bool EsPrimo(int numero)
        {
            int count = 0;
            for(int i = 1; i <= numero; i++)
            {
                if(numero % i ==0)
                    count++;
            }
            return count == 2;
        }
        public int Suma(List<int> numeros, int opcion)
        {
            int resu = 0;
            switch (opcion)
            {
                case 4:
                    resu = numeros.Sum();
                break;
                case 6:
                    resu = numeros.Max();
                break;
                case 7:
                    resu = numeros.Min();
                break;
            }
            return resu;
        } 
    }
}