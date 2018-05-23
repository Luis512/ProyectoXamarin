using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ProyectoXamarin.ViewModels
{
    public class ProfesorItem
    {
        public string Icon { get; set; }
        public Profesor Profesor { get; set; }
    }

    public class ProfesorListPageViewModel : BaseViewModel
    {
        private ProfesorService service { get; set; }
        private ObservableCollection<ProfesorItem> _profesores;

        public ObservableCollection<ProfesorItem> Profesores
        {
            get
            {
                return _profesores;
            }
            set
            {
                if (_profesores != value)
                {
                    _profesores = value;
                    OnPropertyChanged();
                }
            }
        }        

        public ProfesorListPageViewModel()
        {
            service = new ProfesorService();
            GetProfesores();
        }
       
        public async void GetProfesores()
        {
            Profesores = await service.GetProfesoresAsync();
        }
    }
}
