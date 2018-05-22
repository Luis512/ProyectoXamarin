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
                Icon = "icon_user",
                Title = "Log in",
                Command = new Command(() => GoToPage(new LoginPage()))
            });

            menuPage.Menu.Add(new MenuItem()
            {
                Icon = "icon_teacher",
                Title = "Profesores",
                Command = new Command(() => GoToPage(new ProfesorListPage()))
            });

            menuPage.Menu.Add(new MenuItem()
            {
                Icon = "icon_classroom",
                Title = "Secciones",
                Command = new Command(() => GoToPage(new SeccionListPage()))
            });

            menuPage.Menu.Add(new MenuItem()
            {
                Icon = "icon_class",
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