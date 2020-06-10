namespace E3
{
    public class Ponystation4_pro_SaladaEdition : Consola
    {
        public override void AgregarJuego(string nomb, int año, string cons)
        {
            juegos.Add(new Juego(nomb, año, cons));
        }
        public override int RevisarPuntaje()
        {
            return puntaje;
        }
        public override void Jugar(int horas)
        {
            puntaje += 3 * horas;
        }
                public override string ElMasNuevo()
        {
            int nuevo = 0, i = 0, j = 0;
            foreach (var item in juegos)
            {
                if(juegos[i].Añoreturn()>nuevo)
                {
                    j=i;
                    nuevo=juegos[i].Añoreturn();
                }
                i++;
            }
            return juegos[j].nombre;
        }
        public override string ElMasViejo()
        {
            int viejo = 100000, i = 0, j = 0;
            foreach (var item in juegos)
            {
                if(juegos[i].añolanzamiento<viejo)
                {
                    j=i;
                    viejo=juegos[i].añolanzamiento;
                }
                i++;
            }
            return juegos[j].nombre;
        }
    }
}