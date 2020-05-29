using System;
using System.Collections.Generic;
namespace E5
{
    public class Humano:Serpensante
    {
        public static List<string> conocimientos=new List<string>();
        public static List<string> intereses=new List<string>(){"matematica","economica","dibujo tecnico","base de datos","literatura"};
        public static int Puntos = 0;

        public override void estudiar(string estudia)
        {
            int i;
            conocimientos.Add(estudia);
            for(i=0;i<intereses.Count;i++)
            {
                if(intereses[i]==estudia)
                {
                    Puntos++;
                }
            }
        }
        public override int pensar(string tema)
        {
            int ultimos=0,i=0;
            ultimos=conocimientos.Count-5;
            if(conocimientos.Count<=5)
            {
                for(i=0;i<conocimientos.Count;i++)
                {
                    if(conocimientos[i]==tema)
                    {
                        Puntos+=5;
                    }
                }
            }
            else
            {
                for(i=0;i<conocimientos.Count;i++)
                {
                    if(ultimos<=i)
                    {
                        if(conocimientos[i]==tema)
                        {
                            Console.WriteLine("prueba");
                            Puntos+=5;
                        }
                    }
                }
            }
            return Puntos;
        }
    }
}