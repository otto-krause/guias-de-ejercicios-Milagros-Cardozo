namespace E3
{
    public class CaballerosDelZodiaco
    {
        private string nombre;
        private string diosQueProtege;
        private Armadura armadura;
        private string signoZodiacal;

        public CaballerosDelZodiaco(string nombre, string diosQueProtege, Armadura armadura, string signoZodiacal)
        {
            this.nombre = nombre;
            this.diosQueProtege = diosQueProtege;
            this.armadura = armadura;
            this.signoZodiacal = signoZodiacal;
        }

        public string DiosQueProtege { get => diosQueProtege; }
        public string SignoZodiacal { get => signoZodiacal; }

        public string getArmadura()
        {
            return "Nombre de la armadura: " + armadura.Nombre + "\nMaterial de la armadura: " + armadura.Material;
        }
    }
}