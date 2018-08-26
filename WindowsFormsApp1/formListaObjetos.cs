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
    public partial class formListaObjetos : Form
    {
        public formListaObjetos()
        {
            InitializeComponent();
        }

        private void btonIngreso_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (ingItem.Text.Trim()=="")
            {
                MessageBox.Show("Debe ingresar un objeto!");
            }
            else
            { 
                foreach (string item in cjaObjetos1.Items)
                {
                    if (item.Equals(ingItem.Text))
                    {
                        ok = true;
                    }
                }
                    foreach (string item2 in cjaObjetos2.Items)
                    { 
                        if (item2.Equals(ingItem.Text))
                        {
                            ok = true;
                        }
                    }
                    if(ingItem.Text!="" && ok==false)
                       {
                        cjaObjetos1.Items.Add(ingItem.Text.Trim());
                        ingItem.Clear();
                        ingItem.Focus();
                       }
                    else
                {
                    if(ok==true)
                    {
                        MessageBox.Show("Este objeto ya existe!");
                    }
                }
            }

              
        }

        private void trasladarItem_Click(object sender, EventArgs e)
        {

          if (cjaObjetos1.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos para ser trasladados! Ingrese elementos");
            }
            else
            {
                cjaObjetos2.Items.AddRange(cjaObjetos1.Items);
                cjaObjetos1.Items.Clear();
            }
        }

        private void trasladarUnItem_Click(object sender, EventArgs e)
        {
            if (cjaObjetos1.SelectedItem==null)
            {
                MessageBox.Show("No hay elementos seleccionados!");
            }
            else
            {
               cjaObjetos2.Items.Add(cjaObjetos1.SelectedItem);
               cjaObjetos1.Items.Remove(cjaObjetos1.SelectedItem);
            }
        }

        private void regresarUnItem_Click(object sender, EventArgs e)
        {
            if (cjaObjetos2.SelectedItem == null)
            {
                MessageBox.Show("No hay elementos seleccionados!");
            }
            else
            {
                cjaObjetos1.Items.Add(cjaObjetos2.SelectedItem);
                cjaObjetos2.Items.Remove(cjaObjetos2.SelectedItem);
            }
        }

        private void borrarUnItemDer_Click(object sender, EventArgs e)
        {
            cjaObjetos2.Items.Remove(cjaObjetos2.SelectedItem);
        }

        private void rnoMenu2_Click(object sender, EventArgs e)
        {
            this.Close();
            ventana menu1 = new ventana();
            menu1.Show();
        }
    }
}