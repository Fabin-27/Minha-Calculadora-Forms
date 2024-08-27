namespace Minha_Calculadora
{
    public partial class Calculadora : Form
    {

        public decimal resultado { get; set; }
        public decimal valor { get; set; }

        private opera��o Opera��o_Selecionada { get; set; }


        private enum opera��o
        {
            Adi��o,
            Subtra��o,
            Multiplica��o,
            Divis�o
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
            Opera��o_Selecionada = opera��o.Adi��o;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOpera��o.Text = "+";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Opera��o_Selecionada = opera��o.Subtra��o;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOpera��o.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Opera��o_Selecionada = opera��o.Multiplica��o;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOpera��o.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Opera��o_Selecionada = opera��o.Divis�o;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOpera��o.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (Opera��o_Selecionada)
            {

                case opera��o.Adi��o:
                    resultado = valor + Convert.ToDecimal(txtResultado.Text);
                    break;

                case opera��o.Subtra��o:
                    resultado = valor - Convert.ToDecimal(txtResultado.Text);
                    break;

                case opera��o.Multiplica��o:
                    resultado = valor * Convert.ToDecimal(txtResultado.Text);
                    break;

                case opera��o.Divis�o:
                    resultado = valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(resultado);
            lblOpera��o.Text = "=";
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOpera��o.Text = "";
        }
    }
}
