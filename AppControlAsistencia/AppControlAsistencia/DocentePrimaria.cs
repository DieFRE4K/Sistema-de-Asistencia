using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlAsistencia
{
    public partial class DocentePrimaria : Form
    {
        public DocentePrimaria()
        {
            InitializeComponent();
        }

        private void secundariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocenteSecundaria DS = new DocenteSecundaria();
            DS.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
