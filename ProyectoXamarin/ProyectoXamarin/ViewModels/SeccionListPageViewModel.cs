using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using System.Collections.ObjectModel;

namespace ProyectoXamarin.ViewModels
{
    public class SeccionListPageViewModel : BaseViewModel
    {
        private SeccionService service { get; set; }
        private ObservableCollection<SeccionItem> _secciones;
        public ObservableCollection<SeccionItem> Secciones
        {
            get
            {
                return _secciones;
            }
            set
            {
                if (_secciones != value)
                {
                    _secciones = value;
                    OnPropertyChanged();
                }
            }
        }

        public SeccionListPageViewModel()
        {
            service = new SeccionService();
            GetSecciones();
        }

        private async void GetSecciones()
        {
            Secciones = await service.GetSeccionesAsync();
        }
    }
}
