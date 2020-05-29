using System.Collections.Generic;
using System;
namespace E5
{
    public class Cyborg : Serpensante
    {
        public static int Puntos=0;
        public static List<string> conocimientos=new List<string>();
        public static List<string> intereses=new List<string>(){"matematica","economica","dibujo tecnico","base de datos","literatura"};
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
            return conocimientos.Count+Puntos;
        }
    }
}