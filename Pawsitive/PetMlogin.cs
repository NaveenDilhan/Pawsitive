using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pawsitive
{
    public partial class PetMlogin : Form
    {
        public PetMlogin()
        {
            InitializeComponent();
        }

        private void PetMlogin_Load(object sender, EventArgs e)
        {

        }

        private void Backbox_Click(object sender, EventArgs e)
        {
            Welcomepage form3 = new Welcomepage();
            form3.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Signup form4 = new Signup();
            form4.Show();
            this.Hide();
        }
    }
}
