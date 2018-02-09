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

namespace Tienda_Electronica
{
    public partial class Form1 : Form
    {
        Producto[] ventas = new Producto[100];
        int cont = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label3.Text = "Velocidad";
                    label4.Text = "RAM";
                    label5.Text = "Nº Puertos";
                    label6.Text = "Precio";
                    label7.Visible = false;
                    textBox7.Visible = false;
                    limpia();
                    break;
                case 1:
                    label3.Text = "Resolución";
                    label4.Text = "DuraciónBateria";
                    label5.Text = "RAM";
                    label6.Text = "Precio";
                    label7.Visible = false;
                    textBox7.Visible = false;
                    limpia();
                    break;
                case 2:
                    label3.Text = "S.O.";
                    label4.Text = "DuraciónBateria";
                    label5.Text = "Almacenamiento";
                    label6.Text = "RAM";
                    label7.Text = "Precio";
                    label7.Visible = true;
                    textBox7.Visible = true;
                    limpia();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SI TODOS LOS CAMPOS SON DIFERENTES DE NULL O VACIO SE CREA EL OBJETO DEL TIPO COMBOBOX CON LOS CAMPOS DE LOS TEXTBOX
                switch (comboBox1.SelectedIndex)
                {
                    case 0: //CREA TIPO ORDENADOR
                        if (comprobar(textBox1) && comprobar(textBox2) && comprobar(textBox3) && comprobar(textBox4) && comprobar(textBox5)) {
                            Ordenador temp = new Ordenador(textBox1.Text, textBox2.Text, Int32.Parse(textBox4.Text), Double.Parse(textBox6.Text), textBox3.Text, Int32.Parse(textBox5.Text));
                            ventas[cont]=temp;
                            pinta(ventas[cont]);
                        }
                        else
                        {
                            MessageBox.Show("Rellena todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 1: //CREA TIPO TABLET
                        if (comprobar(textBox1) && comprobar(textBox2) && comprobar(textBox3) && comprobar(textBox4) && comprobar(textBox5))
                        {
                            Tablet temp = new Tablet(textBox1.Text,textBox2.Text, Int32.Parse(textBox5.Text), Double.Parse(textBox6.Text), textBox3.Text, textBox4.Text);
                            ventas[cont] = temp;
                            pinta(ventas[cont]);
                    }
                        else
                        {
                            MessageBox.Show("Rellena todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 2: //CREA TIPO MOVIL
                        if (comprobar(textBox1) && comprobar(textBox2) && comprobar(textBox3) && comprobar(textBox4) && comprobar(textBox5) && comprobar(textBox6))
                        {
                        Movil temp = new Movil(textBox1.Text, textBox2.Text, Int32.Parse(textBox6.Text), Double.Parse(textBox7.Text), textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text));
                            ventas[cont] = temp;
                            pinta(ventas[cont]);
                        }
                        else
                        {
                            MessageBox.Show("Rellena todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    default:
                        break;
                }
            limpia();
            cont++;
        }

        private bool comprobar(TextBox text)
        {
            if (text.Text != null && text.Text != "")
                return true;
            else
                return false;
        }

        private void limpia()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void pinta(Producto p)
        {
                listView1.Items.Add(p.ToString());
        }
    }
}
