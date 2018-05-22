using ProyectoXamarin.ViewModels;
using Xamarin.Forms;

namespace ProyectoXamarin.Views
{
	public partial class HomePage : ContentPage
	{         
        public HomePage ()
		{
			InitializeComponent ();

            BindingContext = new HomePageViewModel(Navigation);
        }        
    }
}