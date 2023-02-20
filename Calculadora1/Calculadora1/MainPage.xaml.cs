using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Dato1.Text) && !string.IsNullOrEmpty(Dato2.Text))
            {
                Button boton = (Button)sender;            
                var dato1 = double.Parse(Dato1.Text);
                var dato2 = double.Parse(Dato2.Text);

                var resultado = 0.0d;
                switch (boton.Text)
                {
                    case "Suma":
                        resultado = dato1 + dato2;
                        break;
                    case "Resta":
                        resultado = dato1 - dato2;
                        break;
                    case "Division":
                        resultado = dato1 / dato2;
                        break;
                    case "Multiplicación":
                        resultado = dato1 * dato2;
                        break;
                }
                Resultado.Text = resultado.ToString();
                string mensaje = "";

                if (resultado > 0)
                    mensaje = "Número Positivo +";
                else
                    mensaje = "Número Negativo -";
                DisplayAlert("El resultado es un", mensaje, "OK");
            }
            else
                DisplayAlert("Error", "No se han introducido los datos", "OK");
        }
    }
}
