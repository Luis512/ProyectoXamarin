using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage
    {
        public MasterDetailPage()
        {
            InitializeComponent();

            var menuPage = new MenuPage();

            menuPage.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Log in",
                Command = new Command(() => GoToPage(new LoginPage()))
            });

            menuPage.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Profesores"
            });

            menuPage.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Secciones"
            });

            menuPage.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Clases"
            });

            Master = menuPage;
        }

        private void GoToPage(Page page)
        {
            Detail = page;
            IsPresented = false;
        }
    }
}