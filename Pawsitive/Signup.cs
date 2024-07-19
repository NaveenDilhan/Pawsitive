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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Backbox_Click(object sender, EventArgs e)
        {
            Welcomepage form1 = new Welcomepage();
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PetMlogin form3 = new PetMlogin();
            form3.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void NameText_Enter(object sender, EventArgs e)
        {
             if(textBox2.Text =="")
            {
                textBox2.Text = "username ";
                textBox2.ForeColor = Color.Red;
            }
        }
    }
    
}
