using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_MDI
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        } 

        int a = 0;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            a++;
            Form2 form = new Form2();
            String formText = "Formulario " + a;
            form.Text = formText;
            form.MdiParent = this;
            form.Show();
            
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
           
        }
    }
}
