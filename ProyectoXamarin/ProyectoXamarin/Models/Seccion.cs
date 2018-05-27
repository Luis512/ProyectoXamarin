using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoXamarin.Models
{
    public class Seccion
    {
        public long Id { get; set; }
        public long IdProfesor { get; set; }
        public string Numero { get; set; }
        public int CantidadEstudiantes { get; set; }
        public List<Clase> Clases { get; set; }
    }
}
