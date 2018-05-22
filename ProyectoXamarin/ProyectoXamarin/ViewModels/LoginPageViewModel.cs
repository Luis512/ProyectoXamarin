using ProyectoXamarin.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ProyectoXamarin.ViewModels
{
    public class LoginPageViewModel
    {
        public Profesor Profesor { get; set; }
        public Command SignInCommand { get; set; }

        public LoginPageViewModel()
        {
            Profesor = new Profesor()
            {
                Nombre = "Testing",
                Password = "TESTING"
            };
            SignInCommand = new Command<object>(SignIn);
        }

        private void SignIn(object obj)
        {
            //CALL SERVICE
        }


    }
}
