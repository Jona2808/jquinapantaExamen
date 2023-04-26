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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario1)
        {
            InitializeComponent();
            lblUsuario.Text = usuario1;
        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            var mInicial = txtMontoInicial.Text;
            try
            {
                double nt2 = Double.Parse(mInicial);
                if (nt2 < 0 || nt2 > 2999.00)
                {

                    txtMontoInicial.Text = e.OldTextValue.ToString();
                }
            }
            catch
            {
                return;
            }
        }
        public const double costo = 3000.00;
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
            //Calcula el pago mensual
            double montoI = Convert.ToDouble(txtMontoInicial.Text);
            if (montoI==costo)
            {
                lblResultado.Text = "0.00";
            }
            if (montoI < costo)
            {
                double interes = costo * 0.05;
                double total = (((costo-montoI) + interes) /3);
                
                lblResultado.Text = total.ToString();
            }

        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtMontoInicial.Text = "";
            lblResultado.Text = "";
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usua = lblUsuario.Text;
            string nom = txtNombre.Text;
            string mini = txtMontoInicial.Text;

            double total = costo * 1.05;

            string res = Convert.ToString(total);

            Navigation.PushAsync(new Resumen(usua, nom, mini, res));
        }
    }
}