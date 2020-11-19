using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Riley
    {
        private int felicidad;
        private string emocionesDominante;
        List<Recuerdo> recuerdos;
        List<Recuerdo> centrales;
        List<Recuerdo> plazo;
        List<Recuerdo> largoPlazo;
        List<Recuerdo> negados;

        public string EmocionesDominante { get => emocionesDominante; set => emocionesDominante = value; }
        public List<Recuerdo> Centrales { get => centrales; set => centrales = value; }
        public List<Recuerdo> Negados { get => negados; set => negados = value; }

        public Riley(string emocionesDominante, List<Recuerdo> recuerdos)
        {
            this.felicidad = 1000;
            this.emocionesDominante = emocionesDominante;
            this.centrales = new List<Recuerdo>();
            this.recuerdos = new List<Recuerdo>();
        }
        public void nuevoEvento(string descripcion, DateTime fecha, string emocion)
        {
            Recuerdo recuerdo = new Recuerdo(descripcion, fecha, emocion);
            recuerdos.Add(recuerdo);
        }
        public void asentarRecuerdo()
        {
            foreach(var i in recuerdos)
            {
                switch(i.Emocion)
                {
                    case "Alegria":
                        if(felicidad > 500)
                            centrales.Add(i);
                    break;
                    case "Tristeza":
                        centrales.Add(i);
                        felicidad = (felicidad * 10) / 100;
                    break;
                    default:
                    break;
                }
            }
        }
        public List<Recuerdo> Recuerdosrecientes ()
        {
            return recuerdos.Take(5).ToList();
        }
        public List<Recuerdo> dificiles()
        {
            return recuerdos.Where(r => r.Descripcion.Split(" ").Count() >= 10).ToList();
        }
        public List<Recuerdo> negarRecuerdo()
        {
            foreach(var i in recuerdos)
            {
                switch(emocionesDominante)
                {
                    case "Alegria":
                        negados = recuerdos.Where(r => r.Emocion != "Alegria").ToList();
                    break;
                    case "Tristeza":
                        negados = recuerdos.Where(r => r.Emocion == "Alegria").ToList();
                    break;
                    default:
                        plazo.Add(i);
                    break;
                }
            }
            return negados;
        }
        public void AsentarSelectivo(string palabraClave)
        {
            foreach (var i in recuerdos)
            {
                foreach (var j in centrales)
                {
                    if(i.Descripcion.Contains(palabraClave) && !i.Descripcion.Contains(j.Descripcion))
                    {
                        centrales.Add(i);
                    }
                }
            }
        }
        public void recuerdosAlargoPlazo()
        {
            foreach (var i in recuerdos)
            {
                foreach (var j in negarRecuerdo())
                {
                    if(!i.Descripcion.Contains(j.Descripcion))
                        largoPlazo.Add(i);
                }
            }
        }
        public void restauracionCognitiva()
        {
            if(felicidad + 100 < 1000)
                felicidad += 100;
            else
                felicidad = 1000;
        }
        public void Dormir(string palabraClave)
        {
            asentarRecuerdo();
            AsentarSelectivo(palabraClave);
            recuerdosAlargoPlazo();
            restauracionCognitiva();
            recuerdos.Clear();
        }
        public List<Recuerdo> Rememorar()
        {
            List<DateTime> fechas = new List<DateTime>();
            largoPlazo.OrderBy(l => l.Fecha.Year);
            largoPlazo.ForEach(l => fechas.Add(l.Fecha));
            int edad = DateTime.Now.Year - fechas.First().Year;
            return largoPlazo.Where(l => DateTime.Now.Year - l.Fecha.Year < edad / 2).ToList();
        }
    }
}