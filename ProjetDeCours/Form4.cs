using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDeCours
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCon f1 = new FormCon();
            f1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
