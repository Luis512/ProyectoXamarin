using ProyectoXamarin.Models;
using System.Collections.ObjectModel;

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

        public ProfesorListPageViewModel()
        {
            Profesores = new ObservableCollection<ProfesorItem>
            {
                new ProfesorItem
                {
                    Profesor = new Profesor
                    {

                    }
},
                 new ProfesorItem
                {
                    Profesor = new Profesor
                    {

                    }
                },
                  new ProfesorItem
                {
                    Profesor = new Profesor
                    {

                    }
                }
            };
        }

    }
}
