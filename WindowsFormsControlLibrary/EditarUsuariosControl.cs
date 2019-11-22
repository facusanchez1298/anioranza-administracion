using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class EditarUsuariosControl : UserControl
    {
        private List<CheckBox> paseos = new List<CheckBox>();
        private List<CheckBox> usuarios = new List<CheckBox>();
        private List<Button> botones = new List<Button>();

        public EditarUsuariosControl()
        {
            InitializeComponent();


            paseos.Add(pescaBox);
            paseos.Add(posadaBox);
            paseos.Add(parrillaBox);
            paseos.Add(nauticoBox);
            paseos.Add(museoBox);
            paseos.Add(largaderoBox);
            paseos.Add(cabalgataBox);
            paseos.Add(restauranteBox);
            paseos.Add(campingBox);
            paseos.Add(proveeduriaBox);


            usuarios.Add(crearBox);
            usuarios.Add(modificarBox);
            usuarios.Add(eliminarBox);

            botones.Add(pescaButton);
            botones.Add(posadaButton);
            botones.Add(parrillaButton);
            botones.Add(nauticoButton);
            botones.Add(museoButton);
            botones.Add(largaderoButton);
            botones.Add(cabalgataButton);
            botones.Add(restauranteButton);
            botones.Add(campingButton);
            botones.Add(proveeduriaButton);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EliminarBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PaseosButton_Click(object sender, EventArgs e)
        {
            foreach(CheckBox es in paseos)
            {
                if(es.Visible == false)
                {
                    es.Visible = true;
                }
                else
                {
                    es.Visible = false;
                }
            }

            foreach(Button bu in botones)
            {
                if(bu.Visible == false)
                {
                    bu.Visible = true;
                }
                else
                {
                    bu.Visible = false;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox es in usuarios)
            {
                if (es.Visible == false)
                {
                    es.Visible = true;
                }
                else
                {
                    es.Visible = false;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MuseoBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PescaButton_Click(object sender, EventArgs e)
        {
            if(altaBox1.Visible == false && modificacionBox1.Visible == false && bajaBox1.Visible == false)
            {
                altaBox1.Visible = true;
                modificacionBox1.Visible = true;
                bajaBox1.Visible = true;
            }
            else
            {
                altaBox1.Visible = false;
                modificacionBox1.Visible = false;
                bajaBox1.Visible = false;
            }
        }

        private void PosadaButton_Click(object sender, EventArgs e)
        {
            if (altaBox2.Visible == false && modificacionBox2.Visible == false && bajaBox2.Visible == false)
            {
                altaBox2.Visible = true;
                modificacionBox2.Visible = true;
                bajaBox2.Visible = true;
            }
            else
            {
                altaBox2.Visible = false;
                modificacionBox2.Visible = false;
                bajaBox2.Visible = false;
            }
        }

        private void NauticoButton_Click(object sender, EventArgs e)
        {
            if (altaBox3.Visible == false && modificacionBox3.Visible == false && bajaBox3.Visible == false)
            {
                altaBox3.Visible = true;
                modificacionBox3.Visible = true;
                bajaBox3.Visible = true;
            }
            else
            {
                altaBox3.Visible = false;
                modificacionBox3.Visible = false;
                bajaBox3.Visible = false;
            }
        }

        private void MuseoButton_Click(object sender, EventArgs e)
        {
            if (altaBox4.Visible == false && modificacionBox4.Visible == false && bajaBox4.Visible == false)
            {
                altaBox4.Visible = true;
                modificacionBox4.Visible = true;
                bajaBox4.Visible = true;
            }
            else
            {
                altaBox4.Visible = false;
                modificacionBox4.Visible = false;
                bajaBox4.Visible = false;
            }
        }

        private void AltaBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RestauranteButton_Click(object sender, EventArgs e)
        {
            if (altaBox5.Visible == false && modificacionBox5.Visible == false && bajaBox5.Visible == false)
            {
                altaBox5.Visible = true;
                modificacionBox5.Visible = true;
                bajaBox5.Visible = true;
            }
            else
            {
                altaBox5.Visible = false;
                modificacionBox5.Visible = false;
                bajaBox5.Visible = false;
            }
        }

        private void CampingButton_Click(object sender, EventArgs e)
        {
            if (altaBox6.Visible == false && modificacionBox6.Visible == false && bajaBox6.Visible == false)
            {
                altaBox6.Visible = true;
                modificacionBox6.Visible = true;
                bajaBox6.Visible = true;
            }
            else
            {
                altaBox6.Visible = false;
                modificacionBox6.Visible = false;
                bajaBox6.Visible = false;
            }
        }

        private void ProveeduriaButton_Click(object sender, EventArgs e)
        {
            if (altaBox7.Visible == false && modificacionBox7.Visible == false && bajaBox7.Visible == false)
            {
                altaBox7.Visible = true;
                modificacionBox7.Visible = true;
                bajaBox7.Visible = true;
            }
            else
            {
                altaBox7.Visible = false;
                modificacionBox7.Visible = false;
                bajaBox7.Visible = false;
            }
        }

        private void ParrillaButton_Click(object sender, EventArgs e)
        {
            if (altaBox8.Visible == false && modificacionBox8.Visible == false && bajaBox8.Visible == false)
            {
                altaBox8.Visible = true;
                modificacionBox8.Visible = true;
                bajaBox8.Visible = true;
            }
            else
            {
                altaBox8.Visible = false;
                modificacionBox8.Visible = false;
                bajaBox8.Visible = false;
            }
        }

        private void CabalgataButton_Click(object sender, EventArgs e)
        {
            if (altaBox9.Visible == false && modificacionBox9.Visible == false && bajaBox9.Visible == false)
            {
                altaBox9.Visible = true;
                modificacionBox9.Visible = true;
                bajaBox9.Visible = true;
            }
            else
            {
                altaBox9.Visible = false;
                modificacionBox9.Visible = false;
                bajaBox9.Visible = false;
            }
        }

        private void LargaderoButton_Click(object sender, EventArgs e)
        {
            if (altaBox10.Visible == false && modificacionBox10.Visible == false && bajaBox10.Visible == false)
            {
                altaBox10.Visible = true;
                modificacionBox10.Visible = true;
                bajaBox10.Visible = true;
            }
            else
            {
                altaBox10.Visible = false;
                modificacionBox10.Visible = false;
                bajaBox10.Visible = false;
            }
        }
    }
}
