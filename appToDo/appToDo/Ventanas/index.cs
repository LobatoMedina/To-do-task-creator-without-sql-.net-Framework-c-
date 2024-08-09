using appToDo.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appToDo
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new VentanaTarea().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VentanaMostrarTareas().Show();
        }
    }
}
