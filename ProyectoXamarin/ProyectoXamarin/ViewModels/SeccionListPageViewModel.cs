using ProyectoXamarin.Models;
using System.Collections.ObjectModel;

namespace ProyectoXamarin.ViewModels
{
    public class SeccionListPageViewModel
    {
        public ObservableCollection<SeccionItem> Secciones { get; set; } = new ObservableCollection<SeccionItem>();

        public SeccionListPageViewModel()
        {
            GetSecciones();
        }

        private void GetSecciones()
        {
            //TODO CALL SERVICE
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
