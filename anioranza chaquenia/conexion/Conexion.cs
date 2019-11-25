using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anioranza_chaquenia.conexion
{
    class Conexion
    {
        MySqlConnection conexion;
        DataSet dataSet;

        public Conexion()
        {
            dataSet = new DataSet();
        }
        
        public void conectar()
        {
            this.conexion = new MySqlConnection("server = db4free.net; port = 3306; user id = decodex; password = decodex1234; database = anoranza; oldguids = True");
            //se abre la conexion
            try
            {
                this.conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("el error fue: " + e);
            }
        }

        private void desconectar() {
            this.conexion.Close();
        }

        public void mostrarHorarios(DataGridView dataGridView, string tabla)
        {
            conectar();
            string consulta = String.Format("SELECT * FROM horarios where servicio = '{0}'", tabla);
            MessageBox.Show(consulta);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataAdapter m_datos = new MySqlDataAdapter(comando);
            dataSet = new DataSet();
            m_datos.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
            dataGridView.Columns["id"].Visible = false;
            dataGridView.Columns["servicio"].Visible = false;
            desconectar();
        }
    }
}
