using System.Collections.Generic;
using System.Linq;

namespace E7
{
    public class Android
    {
        List<Aplicacion> app = new List<Aplicacion>();
        public Android ()
        {
            app.Add(new Aplicacion("Twitter", 60, 87, new List<string>{"fotos", "videos"}, 10));
            app.Add(new Aplicacion("Paint Tool Sai", 2, 40, new List<string>{"fotos"}, 2));
            app.Add(new Aplicacion("Legend of Zelda: Ocarina of time", 60, 2, new List<string>{"contactos"}, 45));
        }
        public List<Aplicacion> SonJuegos()
        {
            return app.Where(appli => appli.Interaccion() > 25).ToList();
        }
        public List<Aplicacion> SonRedesSociales()
        {
            return app.Where(appli => appli.InteraccioConElTeclado() == 20 && appli.Permisos.Contains("fotos") && appli.Permisos.Contains("video")).ToList();
        }
        public List<Aplicacion> NoTieneClasificacion()
        {
            return app.Where(appli => !(appli.Permisos.Any(i => i == "videos") && appli.Permisos.Any(i => i == "fotos") && (appli.InteraccioConElTeclado() > 20)) && !(appli.Interaccion() >= 25 && appli.Interaccion() <= 20)).ToList();
        }


    }
}
