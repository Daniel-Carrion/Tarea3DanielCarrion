using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea3DanielCarrion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;

                await Navigation.PushAsync(new vistaDos(usuario));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de alerta", ex.Message, "ok");
            }
        }
    }
}
