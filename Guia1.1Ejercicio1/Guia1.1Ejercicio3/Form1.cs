using Guia1._1Ejercicio3.Models;

namespace Guia1._1Ejercicio3
{
    public partial class Form1 : Form
    {
        Peaje peaje = new Peaje();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCargaPeaje fCargaPeaje = new FormCargaPeaje();

            if (fCargaPeaje.ShowDialog() == DialogResult.OK)
            {
                int dia = Convert.ToInt32(fCargaPeaje.nupDia.Value);
                int cantidadVehiculos = Convert.ToInt32(fCargaPeaje.tbVehiculos.Text);

                peaje.RegistrarResumenDia(dia, cantidadVehiculos);

            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lbVer.Items.Clear();

            lbVer.Items.Add("Los días en que ingresaron más autos que el promedio en el mes:");
            int[] dias = peaje.CalcularLosDiasMayoresAlPromedio(out int cantDias);

            for (int n = 0; n < cantDias; n++)
            {
                lbVer.Items.Add($"{dias[n]} (cantidad: {peaje.VerCantidadAutosEnUnDia(dias[n])})");
            }

            lbVer.Items.Add("¿Cuál de los tercios del mes tuvo mayor movimiento?");
            int tercio = peaje.CalcularTercioDelMesMayor();

            lbVer.Items.Add(tercio);
        }
    }
}
