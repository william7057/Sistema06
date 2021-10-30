using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmListado : Form
    {
        //Defi nicion GLOBAL
        entidadCN objL = new entidadCN();
        public frmListado()
        {
            InitializeComponent();
        }
       
        private void frmListado_Load(object sender, EventArgs e)
        {
            listaUser();

        }
        void listaUser()
        {
            dataGridView1.DataSource = objL.listaUsuarios().Tables["Users"];
        }
    }
}
