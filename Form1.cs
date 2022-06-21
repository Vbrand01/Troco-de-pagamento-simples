namespace FormatoMoeda
{
    public partial class FormatoMoeda : Form
    {
        public FormatoMoeda()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtValorAPagar.Text = "";
            txtValorPago.Text = "";
            txtTotal.Text = "";
            txtCaixa1.Text = "";
            txtTeclaASCII.Text = "";
        }

        private void txtValoraPagar_Leave(object sender, EventArgs e)
        {
            float i;
            if (float.TryParse(txtValorAPagar.Text, out i))
            {
                txtValorAPagar.Text = String.Format("{0:C}", i);
            }
            else
            {
                txtValorAPagar.Text = "";
            }

        }

        private void txtValoPago_Leave(object sender, EventArgs e)
        {
            float i;
            if (float.TryParse(txtValorPago.Text, out i))
            {
                txtValorPago.Text = String.Format("{0:C}", i);
            }
            else
            {
                txtValorPago.Text = "";
            }
        }

        private void txtValoraPagar_Enter(object sender, EventArgs e)
        {
            if (txtValorAPagar.Text != "")
            {
                txtValorAPagar.Text = txtValorAPagar.Text.Substring(3, txtValorAPagar.Text.Length - 3);
            }
        }

        private void txtValorPago_Enter(object sender, EventArgs e)
        {
            if (txtValorPago.Text != "")
            {
                txtValorPago.Text = txtValorPago.Text.Substring(3, txtValorPago.Text.Length - 3);
            }
        }

        private void btoCalcular_Click(object sender, EventArgs e)
        {
            float valorPago, valorAPagar, total;
            valorAPagar = float.Parse(txtValorAPagar.Text.Substring(3, txtValorAPagar.Text.Length - 3));
            valorPago = float.Parse(txtValorPago.Text.Substring(3, txtValorPago.Text.Length - 3));
            total = valorPago - valorAPagar;

            if (total < 0)
            {
                txtTotal.Text = "Erro, não é possivel encerrar a compra";
            }
            else
            {
                txtTotal.Text = String.Format("{0:C}", total);
            }
        }

        private void txtCaixa1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

            }
            if (e.KeyChar == 8)
            {
                return;
            }

           if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void txtTeclaASCII_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Apertei enter");
            }
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                return;
            }

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122))
            {
                e.Handled = true;
            }

            /*if (e.KeyChar < 65 || e.KeyChar > 90)
            {
                e.Handled = true;
            }*/
        }


    }
}