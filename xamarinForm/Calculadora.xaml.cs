using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinForm
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calculadora : ContentPage
	{
    
        string operacao = "";
        double calculo = 0;
		public Calculadora ()
		{
			InitializeComponent ();
            button_voltar.Clicked += Button_voltar_Clicked;
            button_somar.Clicked += Button_somar_Clicked;
            button_multiplicar.Clicked += Button_multiplicar_Clicked;
            button_calcular.Clicked += Button_calcular_Clicked;
            button_limpar.Clicked += Button_limpar_Clicked;
            button_dividir.Clicked += Button_dividir_Clicked;
            button_subtrair.Clicked += Button_subtrair_Clicked;
           
    
        }

        private void Button_subtrair_Clicked(object sender, EventArgs e)
        {
            operacao = "Subtrair";
            entry_valor.Text = String.Empty;
        }

        private void Button_dividir_Clicked(object sender, EventArgs e)
        {
            operacao = "Divisao";
            entry_valor.Text = String.Empty;
        }


        private void Button_multiplicar_Clicked(object sender, EventArgs e)
        {
            operacao = "Multiplicar";
            entry_valor.Text = String.Empty;
        }

        private void Button_somar_Clicked(object sender, EventArgs e)
        {
            operacao = "Somar";
            entry_valor.Text = String.Empty;
        }

        private void Button_calcular_Clicked(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(entry_valor.Text) && entry_valor.Text != "0")
            {
                if(operacao == "Somar")
                {
                    calculo +=  (Convert.ToDouble(entry_valor.Text));
                }
                
                if(operacao == "Multiplicar")
                {
                    calculo *= (Convert.ToDouble(entry_valor.Text));
                }
                
                if(operacao == "Subtrair")
                {
                    calculo -= (Convert.ToDouble(entry_valor.Text));
                }
                if(operacao == "Divisao")
                {
                    calculo /= (Convert.ToDouble(entry_valor.Text) );
                }

                label_resposta.Text = calculo.ToString();
            }

           
                    
        }

        private void Button_limpar_Clicked(object sender, EventArgs e)
        {
            operacao = "";
            calculo = 0;
            entry_valor.Text = String.Empty;
            label_resposta.Text = String.Empty;
        }

        private void Button_voltar_Clicked(object sender, EventArgs e)
        {	

			App.Current.MainPage = new ParOuImpar();
        }
    }
}