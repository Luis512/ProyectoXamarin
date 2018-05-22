using ProyectoXamarin.Models;
using System.Collections.ObjectModel;

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
        public Profesor Profesor { get; set; }
        
        public ProfesorPageViewModel()
        {
            GetProfesor();
        }   
        
        private void GetProfesor()
        {
            //TODO Call service and bring 'Profesor' information
            Profesor = new Profesor
            {
                Nombre = "Test",
                Apellido = "Test",
                Id = "123"
            };

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
