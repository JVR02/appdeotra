using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace appdeotra
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
           

        }
        static string conexion = "SERVER= 127.0.0.1;DATABASE=civil;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        string a;
        string b;
        string c;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                a = "Primaria";
            }

            if (Radioform1_2.Checked == true)
            {
                a = "Bachillerato";
            }
            if (RadioForm1_3.Checked == true)
            {
                a = "Tecnico";
            }
            if (Radioform1_4.Checked == true)
            {
                a = "Tecnologo";
            }
            if (RadioForm1_5.Checked == true)
            {
                a = "Universitario";
            }


            if (RadioForm1_7.Checked == true)
            {
                b = "Antes de 1963";
            }
            if (RadioForm1_8.Checked == true)
            {
                b = "Entre 1963 y 1984";
            }
            if (RadioForm1_9.Checked == true)
            {
                b = "Entre 1985 y 1987";
            }
            if (radioButton3.Checked == true)
            {
                b = "Entre 1988 y 2010";
            }
            if (radioButton4.Checked == true)
            {
                b = "Apartir de 2011";
            }

            if (radioButton2.Checked == true)
            {
                c = "Si";
            }
            if (RadioForm1_13.Checked == true)
            {
                c = "No";
            }
          














            cn.Open();
            string insertar = "INSERT INTO form1 (formacion,anio_constuccion,constructora)values('" + a + "','" + b + "',+ '" + c + "')";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);









            int puntaje = 0;
            if (RadioForm1_7.Checked == true)
                puntaje = puntaje + 4;

            if (RadioForm1_8.Checked == true)
                puntaje = puntaje + 3;
            if (RadioForm1_9.Checked == true)
                puntaje = puntaje + 3;
            if (radioButton3.Checked == true)
                puntaje = puntaje + 2;
            if (radioButton4.Checked == true)
                puntaje = puntaje + 1;
            if (radioButton2.Checked == true)
                puntaje = puntaje + 0;
            if (RadioForm1_13.Checked == true)
                puntaje = puntaje + 3;
            {

            }

            cmd.ExecuteNonQuery();
            cn.Close();
            





            this.Hide();
            Form formulario1 = new Form1(puntaje);
            formulario1.Show();
            MessageBox.Show("Acontinuacion nos daras a conocer alguna informacion acerca del exterior de tu casa o edificio, " +
                " si deseas dirigete al exterior para poder responder. ");
        }

        private void form3_Load(object sender, EventArgs e)
        {

        }
    }
}
