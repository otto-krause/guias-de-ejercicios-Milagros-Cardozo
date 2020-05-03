using System;
using System.Collections.Generic;


namespace E3
{
    public class Album
    {
          List<Figurita> figuritas = new List<Figurita>();
        public Album (){
            figuritas.Add(new Figurita("Julio", "Delantero", "Chile",1));
            figuritas.Add(new Figurita("Mario", "Arquero", "Mexico",2));
            figuritas.Add(new Figurita("Jose", "Mediocampista", "Argentina",3));
            figuritas.Add(new Figurita("Marcos", "Delantero", "Venezuela",4));
            figuritas.Add(new Figurita("Juan", "Delantero", "Colombia", 5));
        }
        public string lista(string nomb, string pai, string posi, int figu)
        {            
            foreach(var k in figuritas)
            {
                if(figu == k.Numfigu)
                {  
                    return "Esta figurita esta repetida";
                }
            }
            figuritas.Add(new Figurita(nomb, posi, pai, figu));
            return "Se agrego correctamente";
        }

        public string CuantosX (string opcion)
        {
            int cont = 0;
            foreach( var k in figuritas)
            {
                if(k.Posicion==opcion)
                {
                    cont += 1;
                }
            }
            return "La cantidad de " + opcion +" es: " + cont;
        }

        public string albumLleno(){
            if (figuritas.Count == 352) return "Esta Completo";
            else return "No esta completo";
        }
    
    }
}