using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anioranza_chaquenia.ventanas
{
    public partial class Administrador : Form
    {
        public Administrador(string typo)
        {
            InitializeComponent();
            labelDescripcion.Text = typo;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            calendario.MinDate = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
