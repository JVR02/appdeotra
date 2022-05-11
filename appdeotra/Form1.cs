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
    public partial class Form1 : Form
    {
        public Form1(int puntos)
        {
            InitializeComponent();
            this.puntos = puntos;
        }

        public Form1()
        {
        }

        static string conexion = "SERVER= 127.0.0.1;DATABASE=civil;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        string a;
        string b;
        string c;
        string d;
        string ee;
        string f;
        string g;
        string h;
            
        string i;
        string j;
        string k;
        string l;
        string m;
        string n;
        






        int puntos;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton75_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           if(radioButton1.Checked==true)
            {
                a = "20 a 30 metros cuadrados";
            }

            if (radioButton2.Checked == true)
            {
                a = "31 a 40 metros cuadrados";
            }

            if (radioButton3.Checked == true)
            {
                a = "41 a 60 metros cuadrados";
            }


            if (radioButton4.Checked == true)
            {
                a = "61 a 70 metros cuadrados";
            }


            if (radioButton5.Checked == true)
            {
                a = "71 a 80 metros cuadrados";
            }

            if (radioButton6.Checked == true)
            {
                a = "81 a 90 metros cuadrados";
            }

            if (radioButton7.Checked == true)
            {
                a = "91 metros cuadrados o mayor";
            }

            if (radioButton8.Checked == true)
            {
                b = "Ladera";
            }

            if (radioButton9.Checked == true)
            {
                b = "Valle";
            }

            if (radioButton10.Checked == true)
            {
                c = "Quebrada";
            }


            if (radioButton11.Checked == true)
            {
                c = "Valle";
            }

            if (radioButton12.Checked == true)
            {
                c = "Montaña";
            }

            if (radioButton13.Checked == true)
            {
                d = "Residencial";
            }

            if (radioButton14.Checked == true)
            {
                d= "Comercial";
            }

            if (radioButton15.Checked == true)
            {
                d = "Educacional";
            }

            if (radioButton16.Checked == true)
            {
                d = "Oficinas";
            }


            if (radioButton17.Checked == true)
            {
                d = "Bodegas";
            }


            if (radioButton18.Checked == true)
            {
                d = "Instalacion deportiva";
            }


            if (radioButton19.Checked == true)
            {
                d = "Centro de salud";
            }



            if (radioButton20.Checked == true)
            {
                d = "Industrial";
            }

            if (radioButton21.Checked == true)
            {
                d = "Hotelero";
            }

            if(radioButton77.Checked == true)
            {
                f = "Si";
            }

            if (radioButton76.Checked == true)
            {
                f = "No";
            }

            if (radioButton25.Checked == true)
            {
                g = "Residencial";
            }

            if (radioButton26.Checked == true)
            {
                g = "Comercial";
            }

            if (radioButton27.Checked == true)
            {
                g = "Educacional";
            }

            if (radioButton28.Checked == true)
            {
                g = "Oficinas";
            }


            if (radioButton29.Checked == true)
            {
                g = "Bodegas";
            }


            if (radioButton30.Checked == true)
            {
                g = "Instalacion deportiva";
            }


            if (radioButton31.Checked == true)
            {
                g = "Centro de salud";
            }



            if (radioButton32.Checked == true)
            {
                g = "Industrial";
            }

            if (radioButton33.Checked == true)
            {
                g = "Hotelero";
            }

            if(radioButton35.Checked == true)
            {
                h = "1";
            }

            if (radioButton36.Checked == true)
            {
                h = "2";
            }

            if (radioButton37.Checked == true)
            {
                h = "3";
            }

            if (radioButton38.Checked == true)
            {
                h = "4";
            }

            if (radioButton39.Checked == true)
            {
                h = "5";
            }


            if (radioButton40.Checked == true)
            {
                h = "6";
            }

            if (radioButton41.Checked == true)
            {
                h = "7 o mayores";
            }

            if (radioButton51.Checked == true)
            {
                i = "Residencial";
            }

            if (radioButton50.Checked == true)
            {
                i = "Comercial";
            }

            if (radioButton49.Checked == true)
            {
                i = "Educacional";
            }


            if (radioButton48.Checked == true)
            {
                i = "Oficinas";
            }

            if (radioButton47.Checked == true)
            {
                i = "Bodegas";
            }

            if (radioButton46.Checked == true)
            {
                i = "Instalacion deportiva";
            }

            if (radioButton45.Checked == true)
            {
                i = "Centro de salud";
            }

            if (radioButton44.Checked == true)
            {
                i = "Industrial";
            }

            if (radioButton43.Checked == true)
            {
                i = "Hotelero";
            }

            if (radioButton42.Checked == true)
            {
                i = "No aplica";
            }

            if (radioButton58.Checked == true)
            {
                j = "1";
            }

            if (radioButton57.Checked == true)
            {
                j= "2";
            }

            if (radioButton56.Checked == true)
            {
                j = "3";
            }

            if (radioButton55.Checked == true)
            {
                j = "4";
            }

            if (radioButton54.Checked == true)
            {
                j = "5";
            }

            if (radioButton53.Checked == true)
            {
                j = "6";
            }
            if (radioButton52.Checked == true)
            {
                j = "7 o mayor";
            }

            if (radioButton78.Checked == true)
            {
                k = "Ninguno";
            }

            if (radioButton63.Checked == true)
            {
                k = "1";
            }

            if (radioButton62.Checked == true)
            {
                k = "2";
            }

            if (radioButton61.Checked == true)
            {
                k = "3";
            }


            if (radioButton60.Checked == true)
            {
                k = "4";
            }

            if (radioButton59.Checked == true)
            {
                k = "5 o mayores";
            }

            if (radioButton78.Checked == true)
            {
                k = "Ninguno";
            }

            if (radioButton64.Checked == true)
            {
                l = "Si";
            }
            if (radioButton65.Checked == true)
            {
                l = "No";
            }

            if (radioButton74.Checked == true)
            {
                m = "Piscina";
            }

            if (radioButton73.Checked == true)
            {
                m = "Cancha";
            }

            if (radioButton72.Checked == true)
            {
                m = "Maquinas de gimnasio";
            }

            if (radioButton71.Checked == true)
            {
                m = "Tanques de agua";
            }

            if (radioButton70.Checked == true)
            {
                m = "Maquinaria industrial";
            }

            if (radioButton69.Checked == true)
            {
                m = "Almacenamiento";
            }

            if (radioButton68.Checked == true)
            {
                m = "Ninguna de las anteriores";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] imageBytes = ms.ToArray();

            ee=Convert.ToBase64String(imageBytes);

            cn.Open();
            string insertar = "INSERT INTO form2 (area_vivienda_frente_fondo,foto_de_vivienda,ubicacion_vivienda,elementos_cercanos,uso_predominante," +
                "uso_diferente,uso_anterior,pisos_totales,uso_primero_piso,piso_de_la_vivivenda,sotanos,comparte_muro,equipos_grandes	)" +
                "values('" + a + "','" + ee + "', '" + c + "','" + d + "','" + b + "','" + f + "','" + g + "','" + h + "', '" + i + "','" + j + "','" + k + "', '" + l + "','" + m + "')";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);


            puntos = 0;
            if (radioButton8.Checked == true)
                puntos = puntos + 2;
            if (radioButton9.Checked == true)
                puntos = puntos + 1;

            if (radioButton10.Checked == true)
                puntos = puntos + 2;
            if (radioButton11.Checked == true)
                puntos = puntos + 1;
            if (radioButton12.Checked == true)
                puntos = puntos + 2;

            if (radioButton15.Checked == true)
                puntos = puntos + 2;
            if (radioButton14.Checked == true)
                puntos = puntos + 1;
            if (radioButton13.Checked == true)
                puntos = puntos + 0;
            if (radioButton16.Checked == true)
                puntos = puntos + 2;
            if (radioButton17.Checked == true)
                puntos = puntos + 3;
            if (radioButton18.Checked == true)
                puntos = puntos + 3;
            if (radioButton19.Checked == true)
                puntos = puntos + 2;
            if (radioButton20.Checked == true)
                puntos = puntos + 4;
            if (radioButton21.Checked == true)
                puntos = puntos + 2;

            if (radioButton35.Checked == true)
                puntos = puntos + 1;
            if (radioButton36.Checked == true)
                puntos = puntos + 1;
            if (radioButton37.Checked == true)
                puntos = puntos + 1;
            if (radioButton38.Checked == true)
                puntos = puntos + 2;
            if (radioButton39.Checked == true)
                puntos = puntos + 2;
            if (radioButton40.Checked == true)
                puntos = puntos + 2;
            if (radioButton41.Checked == true)
                puntos = puntos + 3;

            if (radioButton51.Checked == true)
                puntos = puntos + 0;
            if (radioButton50.Checked == true)
                puntos = puntos + 1;
            if (radioButton49.Checked == true)
                puntos = puntos + 2;
            if (radioButton48.Checked == true)
                puntos = puntos + 2;
            if (radioButton47.Checked == true)
                puntos = puntos + 3;
            if (radioButton46.Checked == true)
                puntos = puntos + 3;
            if (radioButton45.Checked == true)
                puntos = puntos + 2;
            if (radioButton44.Checked == true)
                puntos = puntos + 4;
            if (radioButton43.Checked == true)
                puntos = puntos + 2;

            if (radioButton56.Checked == true)
                puntos = puntos + 1;
            if (radioButton57.Checked == true)
                puntos = puntos + 1;
            if (radioButton58.Checked == true)
                puntos = puntos + 1;
            if (radioButton53.Checked == true)
                puntos = puntos + 2;
            if (radioButton54.Checked == true)
                puntos = puntos + 2;
            if (radioButton55.Checked == true)
                puntos = puntos + 2;
            if (radioButton52.Checked == true)
                puntos = puntos + 3;

            if (radioButton63.Checked == true)
                puntos = puntos + 1;
            if (radioButton62.Checked == true)
                puntos = puntos + 2;
            if (radioButton61.Checked == true)
                puntos = puntos + 3;
            if (radioButton60.Checked == true)
                puntos = puntos + 3;
            if (radioButton59.Checked == true)
                puntos = puntos + 4;

            if (radioButton64.Checked == true)
                puntos = puntos + 3;

            if (radioButton74.Checked == true)
                puntos = puntos + 4;
            if (radioButton73.Checked == true)
                puntos = puntos + 3;
            if (radioButton72.Checked == true)
                puntos = puntos + 3;
            if (radioButton71.Checked == true)
                puntos = puntos + 4;
            if (radioButton70.Checked == true)
                puntos = puntos + 4;
            if (radioButton69.Checked == true)
                puntos = puntos + 3;


            cmd.ExecuteNonQuery();
            cn.Close();




            this.Hide();
            Form formulario1 = new Form2(puntos);
            formulario1.Show();
            MessageBox.Show("Gracias por tus respuestas, ahora tendremos otra seccion de preguntas al interior de la vivienda.  ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOTA: Subir imagen donde evidencies tu vivienda y viviendas aledañas");
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            if (dialogResult1 == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                
            }
        }

        private void radioButton77_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton77.Checked == true)
                panel8.Visible = true;
            else panel8.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Ladera();
            formulario1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario1 = new valle();
            formulario1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
