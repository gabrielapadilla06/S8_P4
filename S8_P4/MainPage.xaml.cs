namespace S8_P4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double numero1) &&
                double.TryParse(txtNumero2.Text, out double numero2))
            {
                lblResultado.Text = $"Resultado: {numero1 + numero2}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }

        private void Restar_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double numero1) &&
                double.TryParse(txtNumero2.Text, out double numero2))
            {
                lblResultado.Text = $"Resultado: {numero1 - numero2}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }

        private void Multiplicar_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double numero1) &&
                double.TryParse(txtNumero2.Text, out double numero2))
            {
                lblResultado.Text = $"Resultado: {numero1 * numero2}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }

        private void Dividir_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double numero1) &&
                double.TryParse(txtNumero2.Text, out double numero2))
            {
                if (numero2 == 0)
                    lblResultado.Text = "No se puede dividir entre cero.";
                else
                    lblResultado.Text = $"Resultado: {numero1 / numero2}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }
    }
}