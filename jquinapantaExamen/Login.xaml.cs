using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jquinapantaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnINGRESAR_Clicked(object sender, EventArgs e)
        {
            const String usuario1 = "estudiante2023";
            const String pass1 = "uisrael2023";
            if ((txtUsuario.Text == usuario1) && (txtContra.Text == pass1))
            {
                DisplayAlert("UISRAEL", "BIENVENIDO " + usuario1, "Cerrar");
                Navigation.PushAsync(new Registro(usuario1));
             
            }
            else if ((txtUsuario.Text != usuario1) && (txtContra.Text == pass1))
            {
                //desplegar una alerta
                DisplayAlert("PRECAUCION", "USUARIO INCORRECTO", "Cerrar");
                txtUsuario.Text = "";
                txtContra.Text = "";
            }
            else if ((txtUsuario.Text == usuario1) && (txtContra.Text != pass1))
            {
                //desplegar una alerta
                DisplayAlert("PRECAUCION", "CONTRASENA INCORRECTA", "Cerrar");
                txtUsuario.Text = "";
                txtContra.Text = "";
            }
            else //((txtUsuario.Text != usuario1) && (txtContra.Text != pass1))
            {
                //desplegar una alerta
                DisplayAlert("PRECAUCION", "USUARIO Y CONTRASENA INCORRECTOS", "Cerrar");
                txtUsuario.Text = "";
                txtContra.Text = "";
            }
        }
    }
}