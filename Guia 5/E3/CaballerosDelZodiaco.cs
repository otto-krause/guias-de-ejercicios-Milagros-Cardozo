namespace E3
{
    public class CaballerosDelZodiaco
    {
        private string nombre;
        private string diosQueProtege;
        private string armaduraNombre;
        private string armaduraMaterial;
        private string signoZodiacal;

        public CaballerosDelZodiaco(string nombre, string diosQueProtege, string armaduraNombre, string armaduraMaterial, string signoZodiacal)
        {
            this.nombre = nombre;
            this.diosQueProtege = diosQueProtege;
            this.armaduraNombre = armaduraNombre;
            this.armaduraMaterial = armaduraMaterial;
            this.signoZodiacal = signoZodiacal;
        }

        public string Nombre { get => nombre; }
        public string DiosQueProtege { get => diosQueProtege; }
        public string ArmaduraNombre { get => armaduraNombre; }
        public string ArmaduraMaterial { get => armaduraMaterial; }
        public string SignoZodiacal { get => signoZodiacal; }
    }
}