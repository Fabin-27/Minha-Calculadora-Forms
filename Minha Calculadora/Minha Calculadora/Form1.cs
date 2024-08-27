namespace Minha_Calculadora
{
    public partial class Calculadora : Form
    {

        public decimal resultado { get; set; }
        public decimal valor { get; set; }

        private operação Operação_Selecionada { get; set; }


        private enum operação
        {
            Adição,
            Subtração,
            Multiplicação,
            Divisão
        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Operação_Selecionada = operação.Adição;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperação.Text = "+";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Operação_Selecionada = operação.Subtração;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperação.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Operação_Selecionada = operação.Multiplicação;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperação.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Operação_Selecionada = operação.Divisão;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperação.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (Operação_Selecionada)
            {

                case operação.Adição:
                    resultado = valor + Convert.ToDecimal(txtResultado.Text);
                    break;

                case operação.Subtração:
                    resultado = valor - Convert.ToDecimal(txtResultado.Text);
                    break;

                case operação.Multiplicação:
                    resultado = valor * Convert.ToDecimal(txtResultado.Text);
                    break;

                case operação.Divisão:
                    resultado = valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(resultado);
            lblOperação.Text = "=";
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperação.Text = "";
        }
    }
}
