using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class IslaPajaro
    {
        List<Pajaros> pajaros = new List<Pajaros>();
        List<Obstaculo> obstaculos = new List<Obstaculo>();
        Pajaros pajaro;

        public IslaPajaro(List<Pajaros> pajaros, List<Obstaculo> obstaculos)
        {
            this.pajaros = pajaros;
            this.obstaculos = obstaculos;
        }
        public void manejoDeLaIraConMatilda()
        {
            pajaros.ForEach(p => p.Ira -= 5);
        }
        public void invacionDeCerditos()
        {
            pajaros.ForEach(p => p.Enojarse());
        }
        public void fistaSorpresa(Pajaros pajaro)
        {
            pajaro.Enojarse();
        }
        public void serieDeEventosDesafortunados()
        {
            manejoDeLaIraConMatilda();
            invacionDeCerditos();
            fistaSorpresa(pajaro);
        }
        public bool atacarIslaCerdito()
        {
            bool ganaron = false;
            foreach (var i in obstaculos)
            {
                Pajaros masFuerte = pajaros.Single(p => p.calcularFuerza() == pajaros.Max(p => p.calcularFuerza()));
                if(masFuerte.calcularFuerza() > i.resistenciaDelObstaculos())
                    ganaron = true;
                else
                    ganaron = false;
                    pajaros.RemoveAll(p => p.calcularFuerza() == masFuerte.calcularFuerza());
            }
            if(ganaron == true)
                obstaculos.Clear();
            return ganaron;
        }
        public void rompioHuevo(Pajaros pajarito)
        {
            pajaros.Add(pajarito);
        }
    }
}