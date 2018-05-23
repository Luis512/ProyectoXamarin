using System.Collections.Generic;
using System.ComponentModel;

namespace ProyectoXamarin.Models
{
    public class Profesor
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
        public bool Sexo { get; set; }
        public List<Seccion> Secciones { get; set; }
    }
}
