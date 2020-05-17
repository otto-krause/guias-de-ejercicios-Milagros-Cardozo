namespace E1
{
    public class Planta
    {
        private int barrasUranio;
        private MrBurns burns;
        private Empleado empleado;

        public Planta(int barrasUranio, Empleado empleado, MrBurns burns)
        {
            this.barrasUranio = barrasUranio;
            this.burns = burns;
            this.empleado = empleado;
        }

        public bool estaEnPeligro()
        {
            return barrasUranio >10000 && empleado.estaDistraido()
                    || !burns.esMillonario();
        }
        public void cambiarEmpleado(Empleado nuevoEmpleado)
        {
            empleado = nuevoEmpleado;
        }
        public void masBarrasdeUranio()
        {
            int barrau;
            barrau = barrasUranio + 5;
        }
    }
}