namespace Ejercicio
{
    public class Habitantes
    {
        private int dinero;
        private string clase;

        public int Dinero { get => dinero; set => dinero = value; }
        public string Clase { get => clase; set => clase = value; }

        public Habitantes(int dinero)
        {
            this.dinero = dinero;
            if(dinero >= 5000000)
                this.clase = "clase alta";
            if(dinero < 5000000 && dinero > 1000000)
                this.clase = "clase media";
            if(dinero < 1000000)
                this.clase = "clase baja";
        }
    }
}