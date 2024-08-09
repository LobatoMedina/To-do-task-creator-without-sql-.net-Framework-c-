using appToDo.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appToDo.Ventanas
{
    public partial class VentanaMostrarTareas : Form
    {
        private PendingTask PendingTask = new PendingTask();
        private TaskRecord TaskRecord = new TaskRecord();
        public VentanaMostrarTareas()
        {
            InitializeComponent();
            ImprimirTareas();
        }
        public void ImprimirTareas()
        {
            foreach(Tareas t in PendingTask.Tasks1)
            {
                CheckBox c = new CheckBox();
                c.Tag = t.Name;
                c.Checked = false;
                c.Text = t.Name;
                checkedListBox1.Items.Add(c.Text);
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkedListBox1.SelectedItem.ToString());
        }
    }   
}
