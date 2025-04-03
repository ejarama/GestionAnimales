using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wGestionAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cmbTipo.SelectedItem.ToString();
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);

                Animal animalito = AnimalFactory.CrearAnimal(tipo, nombre, edad);
                animalito.HacerSonido();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: Se han ingresado datos inválidos" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
