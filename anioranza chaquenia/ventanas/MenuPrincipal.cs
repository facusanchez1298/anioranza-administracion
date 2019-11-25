using anioranza_chaquenia.ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anioranza_chaquenia
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador((sender as ButtonBase).Text);
            administrador.Show();
            this.Close();
        }
    }
}
