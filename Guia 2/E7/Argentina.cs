using System.Collections.Generic;

namespace E7
{
    public class Argentina
    {
        List <Alfajor> alfajores = new List<Alfajor>();
        public Argentina()
        {
            alfajores.Add(new Alfajor("Dulce de Leche", 125, "Teniente del Espacio"));
            alfajores.Add(new Alfajor("Triple Fruta", 100, "Waymayen"));
            alfajores.Add(new Alfajor("Triple de Chocolate", 150, "Borjito"));
        }
        public void BajarElPrecoiDelPetroleo()
        {
            foreach (var i in alfajores)
                i.precio += 80;

        }
        public void MillaiHablaPorTV()
        {
            foreach (var i in alfajores)
                i.precio = i.precio*2;
        }
        public void CoronaVairas()
        {
            foreach (var i in alfajores)
            {
                if(i.nombreDeLaEmpresa!="Waymayen")
                    i.precio += 1000;
            }
        }
        public string EstadoDeInflaccion()
        {
            int total = 0;
            string estado = "";
            foreach (var i in alfajores)
            {
                total += i.precio;
            }
            if(total < 500)
                estado = "normal";
                
            if(total >= 500 && total < 1000)
                estado = "super";

            if(total >= 1000)
                estado = "hyper";
            
            return estado;
        }
        public bool ArgentinaEnDefault()
        {
            return EstadoDeInflaccion() == "hyper" && alfajores.Count == 1;
        }
    }
}