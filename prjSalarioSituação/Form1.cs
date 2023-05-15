namespace prjSalarioSituação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            decimal salLiqui = 0, descontoimposto = 0;

            if (decimal.TryParse(txtSalBruto.Text, out decimal res) == false)
            {
                lblSituacao.Text = "Digite o seu salário!";
            }
            else
            {
                decimal salbruto = Convert.ToDecimal(txtSalBruto.Text);

                if (ckValeTransporte.Checked == true && ckConvenio.Checked == false)
                {
                    descontoimposto = salbruto * 0.06m;
                    salLiqui = salbruto - descontoimposto;
                }
                if (ckConvenio.Checked == true && ckValeTransporte.Checked == false)
                {
                    descontoimposto = salbruto - 20;
                    salLiqui = salbruto - descontoimposto;
                }
                if (ckConvenio.Checked == true && ckValeTransporte.Checked == true)
                {
                    descontoimposto = (salbruto * 0.06m) + 20;
                    salLiqui = salbruto - descontoimposto;
                }

                if (salbruto < 980 && salLiqui > 0)
                {
                    descontoimposto = salbruto * 0.08m;
                    salLiqui = salLiqui - descontoimposto;
                }
                else if (salbruto < 980 && salLiqui == 0)
                {
                    salLiqui = salbruto * 0.92m;
                }
                if (salbruto >= 980 && salbruto < 1450 && salLiqui > 0)
                {
                    descontoimposto = salbruto * 0.09m;
                    salLiqui = salLiqui - descontoimposto;
                }
                else if (salbruto >= 980 && salbruto < 1450 && salLiqui == 0)
                {
                    salLiqui = salbruto * 0.91m;
                }
                if (salbruto >= 1450 && salbruto < 2200 && salLiqui > 0)
                {
                    descontoimposto = salbruto * 0.10m;
                    salLiqui = salLiqui - descontoimposto;
                }
                else if (salbruto >= 1450 && salbruto < 2200 && salLiqui == 0)
                {
                    salLiqui = salbruto * 0.90m;
                }
                if (salbruto >= 2200 && salLiqui > 0)
                {
                    descontoimposto = salbruto * 0.11m;
                    salLiqui = salLiqui - descontoimposto;
                }
                else if(salbruto >= 2200 && salLiqui == 0)
                {
                    salLiqui = salbruto * 0.89m;
                }

                txtResult.Text = salLiqui.ToString();
            }
        }
    }
}