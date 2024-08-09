using appToDo.Catalogos;
using appToDo.clases;
using System;
using System.Collections;
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
    public partial class VentanaTarea : Form
    {
        public DateTime thisDay = DateTime.Today;
        public DateTime FinalFecha = DateTime.Today;
        //ListasLigadas dependencia
        private ListaLigada l;
        private CatalogoListasLigadas listaDeListas = new CatalogoListasLigadas();
        //Vamos a meternos con el tiempo y las tareas ciclicas
        public ArrayList repeat = new ArrayList();
        public ArrayList dayTo = new ArrayList();
        private ListaLigadaCircular TareasCiclicas = new ListaLigadaCircular();
        private PendingTask pt = new PendingTask();
        public int hour = DateTime.Now.Hour; // pendiente si me alcanza el fucking tiempo
        public int i = 0;
        public int j = 0;
        public VentanaTarea()
        {
            InitializeComponent();
            dateTimePicker2.MinDate = thisDay;

            // MessageBox.Show(""+(int)thisDay.DayOfWeek);  obtener el dia de la semana por numero
            ValidarRadioButton();
        }
        //Inicio metodos propios
        //Validar campos
        public void ValidarCheckBox(CheckBox c, int value)
        {
            if (repeat.Count == 0) return;
            if (!c.Checked)
            {
                repeat.Remove(value);
            }
            else
            {
                repeat.Add(value);
            }
        }
        private void ValidarRadioButton()
        {
            if (radioButton1.Checked)
            {
                quitarCheckbox();
                panel2.Visible = false;
            }
            if (radioButton2.Checked)
            {
                panel2.Visible = true;
                //codigo dedicado a la ligacircular
            }
        }
        private void quitarCheckbox()
        {
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
        }
        private Tareas ObtenerTarea(String identificador)
        {
            foreach (Tareas t in pt.Tasks)
            {
                if (t.Name == identificador) { return t; }
            }
            return null;
        }
         private void ActualizarComboBox()
            {
                Tareas[] array = pt.Tasks.ToArray();
                comboBox1.Items.Clear();
                foreach (Tareas ta in array)
                {
                    comboBox1.Items.Add(ta.Name);
                }
            }
            //fin metodos propios

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Visible = true;
                radioButton1.Checked = true;
                checkBox3.Checked = false;
            }
            else
            {
                panel1.Visible = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ValidarRadioButton();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ValidarRadioButton();
        }



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) {
                dateTimePicker2.Visible = true;
                checkBox1.Checked = false;
            }
            else {
                dateTimePicker2.Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tareas t = null;
            if (!checkBox2.Checked)
            {
                    if (checkBox3.Checked) { FinalFecha = dateTimePicker2.Value; }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Ingresa un titulo");
                }
                else
                {
                    t = new Tareas(i, textBox1.Text, thisDay, FinalFecha);
                    MessageBox.Show("Tarea Creada con exito");
                    pt.InsertTask(t);
                    ActualizarComboBox();
                }
            }
            else
            {
                listaDeListas.AñadirListaL(l);
                checkBox2.Checked = false;
                button1.Text = "Crear tarea";
                j = 0;
            }
            textBox1.Text = "";
        }
  
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                checkBox2.Checked = false;
                MessageBox.Show("No hay tarea raiz disponibles");
                return;
            }
            if (checkBox2.Checked)
            {
                panel3.Visible = true;
                button1.Text = "Terminar de añadir";
                ActualizarComboBox();
            }
            else panel3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tareas tareas = ObtenerTarea(comboBox1.SelectedItem.ToString());
            ListaLigada l1 = listaDeListas.getListaLigada(tareas);
            if (l1 != null) {
                l = l1;
            }
            else
            {
                l = new ListaLigada();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Escribe algo mmhuevo");
                return;
            }
            if (comboBox1.SelectedItem != null)
            {
                if (l.Cabeza == null)
                {
                    l.InsertarTarea(ObtenerTarea(comboBox1.SelectedItem.ToString()));
                }
                l.InsertarTarea(new Tareas(j++, textBox1.Text, thisDay, FinalFecha));
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheckBox(checkBox4, 1);
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheckBox(checkBox5, 2);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
                ValidarCheckBox(checkBox6, 3);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheckBox(checkBox7, 4);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheckBox(checkBox8, 5);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheckBox((CheckBox)sender, 6);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheckBox((CheckBox)sender, 7);
        }
    }
}
