using System;

namespace AndersonMiguelBiblioteca
{
    public class Profesor : IColegio
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public void IngresaDatos()
        {
            _ = Nombre + Apellido;
        }
    }
}
