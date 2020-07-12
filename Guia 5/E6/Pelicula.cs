namespace E6
{
    public class Pelicula
    {
        private string nombre;
        private string genero;
        private string año;
        private string director;
        public Pelicula(string nombre, string genero, string año, string director)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.año = año;
            this.director = director;
        }
        public string Nombre { get => nombre; }
        public string Genero { get => genero; }
        public string Año { get => año; }
        public string Director { get => director; }

        public string Descripcion()
        {
            return "La pelicula que busca es: \nTitulo: " + this.nombre + "\nGenero: " +this.genero+ "\nDirector: " + this.director + "\nAño: " + this.año;
        }
    }
}