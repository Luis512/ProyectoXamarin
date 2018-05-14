using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailPage
	{
		public MasterDetailPage ()
		{
			InitializeComponent ();

            var paginaMenu = new MenuPage();

            paginaMenu.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Log in"
            });

            paginaMenu.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Profesores"
            });

            paginaMenu.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Secciones"
            });

            paginaMenu.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Clases"
            });

            Master = paginaMenu;
        }
	}
}