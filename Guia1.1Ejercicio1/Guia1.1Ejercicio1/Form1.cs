using Guia1._1Ejercicio1.Models;

namespace Guia1._1Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();



        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nupModelo.Value);
            int a�oACalcular = Convert.ToInt32(nupA�oCalcular.Value);
            double valorFabrica = Convert.ToDouble(tbValorFabrica.Text);
            int vidaUtil = Convert.ToInt32(tbValorFabrica.Text);
            double tasaDepreciacion = Convert.ToDouble(tbValorFabrica.Text);

            Moto m = new Moto(marca, modelo, valorFabrica);


            FormVer fVer = new FormVer();
            fVer.lbResultado.Items.Add(m.VerDescripcion());

            double valorLineal = m.CalcularDepreciacionLineal(a�oACalcular, vidaUtil);
            fVer.lbResultado.Items.Add($"Depreciaci�n lineal: ${valorLineal,10:f2}");

            double valorAnual = m.CalcularDepreciacionAnual(a�oACalcular, tasaDepreciacion);
            fVer.lbResultado.Items.Add($"Depreciaci�n anual: ${valorAnual,10:f2}");

            fVer.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
