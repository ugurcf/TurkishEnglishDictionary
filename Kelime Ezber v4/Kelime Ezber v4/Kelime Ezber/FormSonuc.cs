using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Ezber
{
    public partial class FormSonuc : Form
    {
        public FormSonuc()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.IlkAcilis(false);
            anaSayfa.ShowDialog();
            this.Close();
        }
    }
}
