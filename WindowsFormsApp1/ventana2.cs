using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = comboBox1.Items[e.Index].ToString();
                Brush borde = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush pincel = new SolidBrush(color);
                Pen bolig = new Pen(e.ForeColor);

                e.Graphics.DrawRectangle(bolig, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);
                e.DrawFocusRectangle();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        {

        }
        }

        private void btnMosColor_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            comboBox1.Items.AddRange(colores);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            int anios = DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
            edad.Text = anios + "años";
        }
        private void btnAceptarDatosP_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese datos obligatorios");
            }
            else
            {
           
                MessageBox.Show(
                    "Nombre " + textBox1.Text.Trim() +
                    "\nApellido " + textBox2.Text.Trim() +
                    "\nFecha de nacimiento" + dateTimePicker1.Value + edad +
                    "\nSexo" + (string)(radioButton1.Checked ? "hombre" : "mujer") +
                    "\nEstilo musical:" +(string)(checkBox1.Checked ? "rock," : "") + (string)(checkBox2.Checked ? "blues," : "") +
                    (string)(checkBox3.Checked ? "jazz," : "") + (string)(checkBox4.Checked ? "reggae,":"") +
                    (string)(checkBox5.Checked ? "pop," : "") + (string)(checkBox6.Checked ? "clasica,":"")+
                    "\nColor:"+comboBox1.SelectedItem);

                   // "\nEstilos musicales: "+ rock.ToString());
            }

        }

        private void rnoMenu1_Click(object sender, EventArgs e)
        {
            this.Close();
            ventana menu = new ventana();
            menu.Show();
        }
    }
}
