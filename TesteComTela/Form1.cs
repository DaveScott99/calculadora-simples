namespace TesteComTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void c(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            double n1, n2, total;

            n1 = Convert.ToDouble(txtValor1.Text);

            n2 = Convert.ToDouble(txtValor2.Text);

            total = n1 + n2;

            txtTotal.Text = total.ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            Double n1, n2, total;

            n1 = Convert.ToDouble(txtValor1.Text);

            n2 = Convert.ToDouble(txtValor2.Text);

            total = n1 - n2;

            txtTotal.Text = total.ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            Double n1, n2, total;

            n1 = Convert.ToDouble(txtValor1.Text);

            n2 = Convert.ToDouble(txtValor2.Text);

            total = n1 * n2;

            txtTotal.Text = total.ToString();

        }

        private void txtDividir_Click(object sender, EventArgs e)
        {
            Double n1, n2, total;

            n1 = Convert.ToDouble(txtValor1.Text);

            n2 = Convert.ToDouble(txtValor2.Text);

            if (n2 < 0)
            {
                txtTotal.Text = "ERRO: Não é possível dividir por 0";
            }
            else
            {
                total = n1 / n2;
                txtTotal.Text = total.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}