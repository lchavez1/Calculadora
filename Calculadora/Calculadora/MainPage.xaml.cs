using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        float valor = 0;
        bool bandera = false;
        bool banderaResta = false;
        bool banderaMult = false;
        int operacion = 0; //1-suma, 2-resta, 3-multiplicacion
        public MainPage()
        {
            InitializeComponent();
            btn0.Clicked += Btn0_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;
            btn6.Clicked += Btn6_Clicked;
            btn7.Clicked += Btn7_Clicked;
            btn8.Clicked += Btn8_Clicked;
            btn9.Clicked += Btn9_Clicked;
            btnPto.Clicked += BtnPto_Clicked;
            btnSuma.Clicked += BtnSuma_Clicked;
            btnIgual.Clicked += BtnIgual_Clicked;
            btnMenus.Clicked += BtnMenus_Clicked;
            btnMult.Clicked += BtnMult_Clicked;
        }

        private void BtnMult_Clicked(object sender, EventArgs e)
        {
            if (banderaMult == true)
            {
                valor = valor * float.Parse(lblresultado.Text);
            }
            else
            {
                valor = float.Parse(lblresultado.Text);
            }
            bandera = true;
            operacion = 3;
        }

        private void BtnMenus_Clicked(object sender, EventArgs e)
        {
            if(banderaResta == true)
            {
                valor = valor - float.Parse(lblresultado.Text);
            } else
            {
                valor = float.Parse(lblresultado.Text);
            }
            bandera = true;
            operacion = 2;
        }

        private void BtnIgual_Clicked(object sender, EventArgs e)
        {
            if(operacion == 1)
            {
                valor = valor + float.Parse(lblresultado.Text);
            } else if(operacion == 2)
            {
                valor = valor - float.Parse(lblresultado.Text);
            } else if (operacion == 3)
            {
                valor = valor * float.Parse(lblresultado.Text);
            }
         
            lblresultado.Text = valor.ToString();
            valor = 0;
            bandera = true;
        }

        private void BtnSuma_Clicked(object sender, EventArgs e)
        {
            valor = valor + float.Parse(lblresultado.Text);
            bandera = true;
            operacion = 1;
        }

        private void BtnPto_Clicked(object sender, EventArgs e)
        {
            lblresultado.Text = lblresultado.Text + btnPto.Text;
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            if (lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn9.Text;
            bandera = false;
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            if (lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn8.Text;
            bandera = false;
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            if (lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn7.Text;
            bandera = false;
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            if (lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn6.Text;
            bandera = false;
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            if(lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn5.Text;
            bandera = false;
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            if (lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn4.Text;
            bandera = false;
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            if (lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn3.Text;
            bandera = false;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            if (lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn2.Text;
            bandera = false;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (lblresultado.Text == "0" || bandera == true)
            {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn1.Text;
            bandera = false;
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            if(lblresultado.Text != "0" || bandera == true) {
                lblresultado.Text = "";
            }
            lblresultado.Text = lblresultado.Text + btn0.Text;
            bandera = false;

        }
    }
}
