using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ProyectoXamarin.ViewModels
{
    public class ProfesorItem
    {
        public string Icon { get; set; }
        public Profesor Profesor { get; set; }
    }

    public class ProfesorListPageViewModel
    {
        public ObservableCollection<ProfesorItem> Profesores { get; set; } = new ObservableCollection<ProfesorItem>();

        private ProfesorService service { get; set; }

        public ProfesorListPageViewModel()
        {
            Profesores = GetProfesores();
        }

       public ObservableCollection<ProfesorItem> GetProfesores()
        {
            //var profesores = await service.GetProfesoresAsync();
            var profesores = new ObservableCollection<ProfesorItem>
            {
                new ProfesorItem
                {
                    Profesor = new Profesor
                    {
                        Nombre = "Luis",
                        Apellido = "Alvarez",
                        Id = "12345689"
                    }
                },
                new ProfesorItem
                {
                    Profesor = new Profesor
                    {
                        Nombre = "Annia",
                        Apellido = "Vega",
                        Id = "12345689"
                    }
                },
                new ProfesorItem
                {
                    Profesor = new Profesor
                    {
                        Nombre = "Marco",
                        Apellido = "Alvarez",
                        Id = "12345689"
                    }
                }
            };

            return profesores;
        }
       
    }
}
