using ProyectoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProyectoXamarin.ViewModels
{
    public class SeccionItem
    {
        public string Icon { get; set; }
        public Seccion Seccion { get; set; }
    }

    public class ProfesorPageViewModel
    {
        public ObservableCollection<SeccionItem> Secciones { get; set; } = new ObservableCollection<SeccionItem>();

        public ProfesorPageViewModel()
        {
            Secciones = new ObservableCollection<SeccionItem>
            {
                new SeccionItem
                {
                    Seccion = new Seccion
                    {
                       Numero = "1-1",
                       CantidadEstudiantes = 30
                    }
},
                 new SeccionItem
                {
                    Seccion = new Seccion
                    {
                       Numero = "1-2",
                       CantidadEstudiantes = 25
                    }
                },
                  new SeccionItem
                {
                    Seccion = new Seccion
                    {
                       Numero = "1-3",
                       CantidadEstudiantes = 41
                    }
                }
            };
        }            
    }
}
