using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_historial_cilinico
{
    public partial class Form1 : Form
    {
        SqlConnection cadena = new SqlConnection("Data Source=OsmaryRamirez;Initial Catalog=Historial_clinico;User ID=sa;Password=12345;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {

        }
    }
}
