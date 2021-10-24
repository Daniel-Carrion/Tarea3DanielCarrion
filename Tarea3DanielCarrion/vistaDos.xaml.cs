using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea3DanielCarrion
{
    public partial class vistaDos : ContentPage
    {
        public vistaDos(string usuario)
        {
            InitializeComponent();
            vUsuario.Text = "Usuario: "+ usuario;
        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {
            try
            {

                //Declaraciones de variables
                double valorS1 = Convert.ToDouble(valorSeguimiento1.Text);
                double valorE1 = Convert.ToDouble(valorExamen1.Text);
                double valorS2 = Convert.ToDouble(valorSeguimiento2.Text);
                double valorE2 = Convert.ToDouble(valorExamen2.Text);

                //Operaciones
                double notaP1 = (valorS1 * 0.3) + (valorE1 * 0.2);
                double notaP2 = (valorS2 * 0.3) + (valorE2 * 0.2);


                valorParcial1.Text = Convert.ToString(notaP1);
                valorParcial2.Text = Convert.ToString(notaP2);

                double notaF = notaP1 + notaP2;

                valorNotaFinal.Text = Convert.ToString(notaF);

                string estado = null;

                if (notaF >= 7)
                {
                    estado = "Aprobado";
                }
                else
                if ((notaF >= 5) && (notaF <= 6.9))
                {
                    estado = "Complementario";
                }
                else
                if (notaF < 5)
                {
                    estado = "Reprobado";
                }

                txtEstado.Text = estado;

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta: ", ex.Message, "ok");
            }

        }

        private void txtEstado_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtEstado.Text == "Aprobado")
            {
                txtEstado.BackgroundColor = Color.GreenYellow;
            }
            else
                if (txtEstado.Text == "Reprobado")
            {
                txtEstado.BackgroundColor = Color.MediumVioletRed;
            }
            else
                txtEstado.BackgroundColor = Color.OrangeRed;
        }
    }
}