using anioranza_chaquenia.conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anioranza_chaquenia.ventanas
{
    public partial class Administrador : Form
    {
        Conexion conexion;
        string tipo;
        public Administrador(string typo)
        {
            InitializeComponent();
            this.tipo = typo;
            labelDescripcion.Text = typo;
            conexion = new Conexion();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            calendario.MinDate = DateTime.Now;
            conexion.mostrarHorarios(dataGridView1, this.tipo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
