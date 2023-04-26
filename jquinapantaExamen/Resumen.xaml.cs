using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace jquinapantaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usua, string nom, string mini, string res)
        {
            InitializeComponent();
            lblUsu.Text = usua;
            lblNombre.Text = nom;
            lblMontoMin.Text = mini;
            lblCalculo.Text = res;
        }
    }
}