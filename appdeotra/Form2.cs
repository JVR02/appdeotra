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
    public partial class Form2 : Form
    {
        public Form2(int puntos2)
        {
            InitializeComponent();
            this.puntos2 = puntos2;
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
        string img1;
        string img2;
        string img3;
        string img4;


        int puntos2;
        int puntosfinales;
        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton37.Checked == true)
                pictureBox1.Visible = true;



            else pictureBox1.Visible = false;

            if (radioButton37.Checked == true)
                pictureBox2.Visible = true;



            else pictureBox2.Visible = false;


            if (radioButton37.Checked == true)
                button1.Visible = true;



            else button1.Visible = false;

            if (radioButton37.Checked == true)
                button2.Visible = true;
            else button2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario1 = new prefabricado();
            formulario1.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked==true)
            {
                a = "2 metros";
            }
            if (radioButton2.Checked == true)
            {
                a = "2.1 a 2.5 metros";
            }
            if (radioButton3.Checked == true)
            {
                a = "2.6 a 3 metros";
            }
            if (radioButton4.Checked == true)
            {
                a = "mayor a 3.1 metros";
            }

            if (botonmaposteria.Checked == true)
            {
                b = "Mamposteria";
            }

            if (radioButton6.Checked == true)
            {
                b = "Concreto reforzado";
            }

            if (radioButton7.Checked == true)
            {
                b = "Prefabricado";
            }

            if (radioButton8.Checked == true)
            {
                b = "Acero";
            }

            if (radioButton9.Checked == true)
            {
                b = "Madera";
            }

            if (radioButton10.Checked == true)
            {
                b = "Adobe";
            }

            if (radioButton11.Checked == true)
            {
                b = "Tapia";
            }

            if (radioButton12.Checked == true)
            {
                b = "Guadua";
            }

            if (radioButton13.Checked == true)
            {
                b =Convert.ToString(textBox2.Text);
            }

            if (radioButton14.Checked == true)
            {
                c = "Reforzada";
            }

            if (radioButton15.Checked == true)
            {
                c = "No reforzada";
            }

            if (radioButton16.Checked == true)
            {
                c = "No confinada";
            }

            if (radioButton17.Checked == true)
            {
                d = "Muro estructural";
            }

            if (radioButton18.Checked == true)
            {
                d = "Pórtico";
            }

            if (radioButton19.Checked == true)
            {
                d = "Sistema dual o combinado";
            }

            if (radioButton39.Checked == true)
            {
                d = "Prefabricado";
            }

            if (radioButton20.Checked == true)
            {
                ee = "Yeso";
            }

            if (radioButton21.Checked == true)
            {
                ee = "Madera";
            }

            if (radioButton22.Checked == true)
            {
                ee = "PVC";
            }

            if (radioButton23.Checked == true)
            {
                ee = "Drywall";
            }

            if (radioButton24.Checked == true)
            {
                ee = "Fibrocemento";
            }

            if (radioButton25.Checked == true)
            {
                ee=Convert.ToString(textBox1.Text);
            }

            if (radioButton27.Checked == true)
            {
                f = "Losa de concreto aligerado";
            }

            if (radioButton26.Checked == true)
            {
                f = "Losa de concreto maciza";
            }

            if (radioButton5.Checked == true)
            {
                f = "Viga de madera";
            }

            if (radioButton28.Checked == true)
            {
                f = "Viga de acero";
            }

            if (radioButton34.Checked == true)
            {
                g = "Losa de concero aligerado";
            }

            if (radioButton33.Checked == true)
            {
                g = "Losa de concreto maciza";
            }

            if (radioButton32.Checked == true)
            {
                g = "Zinc";
            }

            if (radioButton31.Checked == true)
            {
                g = "Termina en plancha";
            }

            if (radioButton30.Checked == true)
            {
                g = "placa facil";
            }

            if (radioButton29.Checked == true)
            {
                g = "Eternit";
            }

            if (radioButton35.Checked == true)
            {
                g = "Estructura de madera y tejas de barro";
            }

            if (radioButton36.Checked == true)
            {
                g = "Metálica";
            }

            if (radioButton37.Checked == true)
            {
                h = "si";
            }

            if (radioButton38.Checked == true)
            {
                h = "no";
            }

            if (radioButton42.Checked == true)
            {
                i = "si";
            }

            if (radioButton41.Checked == true)
            {
                i = "no";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] imageBytes = ms.ToArray();

            img1=Convert.ToBase64String(imageBytes);
            
            MemoryStream ms1 = new MemoryStream();
            pictureBox2.Image.Save(ms1, pictureBox2.Image.RawFormat);
            byte[] imageBytes1 = ms1.ToArray();

            img2 = Convert.ToBase64String(imageBytes1);

            MemoryStream ms2 = new MemoryStream();
            pictureBox4.Image.Save(ms2, pictureBox4.Image.RawFormat);
            byte[] imageBytes2 = ms2.ToArray();

            img3=Convert.ToBase64String(imageBytes2);

            MemoryStream ms3 = new MemoryStream();
            pictureBox3.Image.Save(ms3, pictureBox3.Image.RawFormat);
            byte[] imageBytes3 = ms3.ToArray();

            img4 = Convert.ToBase64String(imageBytes3);

            cn.Open();
            string insertar = "INSERT INTO form3 (altura_pisos,material_costruccion,tipo_mamposteria,tipo_concreto,tipo_prefabricado,construccion_piso_vivienda,tipo_techo,hundimiento,grietas,foto_1,foto_2,foto_3,foto_4)" +
                "values('" + a + "','" + b + "', '" + c + "','" + d + "','" + ee + "','" + f + "','" + g + "','" + h + "', '" + i + "', '" + img1 + "', '" + img2 + "', '" + img3 + "', '" + img4 + "') ";
            MySqlCommand cmd = new MySqlCommand(insertar,cn);



            if (radioButton1.Checked == true)
                puntos2 = puntos2 + 1;
            if (radioButton2.Checked == true)
                puntos2 = puntos2 + 2;
            if (radioButton3.Checked == true)
                puntos2=puntos2 + 3;
           if (radioButton4.Checked == true)
                puntos2=puntos2 + 3;
           if(botonmaposteria.Checked == true) 
                puntos2=puntos2 + 2;
           if(radioButton6.Checked == true)
                puntos2=puntos2 + 1;
           if(radioButton7.Checked == true)
                puntos2=puntos2 + 2;
           if(radioButton8.Checked == true)
                puntos2=puntos2 + 1;
           if(radioButton9.Checked == true)
                puntos2=puntos2 + 2;
           if(radioButton10.Checked == true)
                puntos2=puntos2 + 3;
           if(radioButton11.Checked == true)
                puntos2=puntos2  +3;
          if(radioButton12.Checked == true)
                puntos2=puntos2 + 3;
          if(radioButton14.Checked == true)
                puntos2=puntos2 +1;
          if(radioButton15.Checked == true)
                puntos2 =puntos2 + 1;
         if(radioButton16.Checked == true)
                puntos2=puntos2 + 1;
         if(radioButton17.Checked == true)
                puntos2=puntos2 + 1;
         if(radioButton18.Checked == true)
                puntos2=puntos2 + 1;
         if(radioButton19.Checked == true)
                puntos2=puntos2 + 1;
         if(radioButton39.Checked == true)
                puntos2=puntos2 +2;
         if(radioButton20.Checked == true)
                puntos2=puntos2 +2;
         if(radioButton21.Checked == true)
                puntos2=puntos2 +2;
         if(radioButton22.Checked == true)
                puntos2=puntos2 +2;
         if(radioButton23.Checked == true)
                puntos2=puntos2 +3;
         if(radioButton24.Checked==true)
                puntos2=puntos2 +1;
         if(radioButton27.Checked == true)
                puntos2 = puntos2 +1;
         if(radioButton26.Checked == true)
                puntos2=puntos2 +1;
         if(radioButton5.Checked == true)
                puntos2=puntos2 +2;
         if(radioButton28.Checked == true)
                puntos2=puntos2 +1;
         if(radioButton34.Checked == true)
                puntos2=puntos2 +1;
         if(radioButton33.Checked == true)
                puntos2=puntos2 +1;
         if(radioButton32.Checked == true)
                puntos2=puntos2 +3;
         if(radioButton31.Checked == true)
                puntos2=puntos2 +1;
         if(radioButton30.Checked==true)
                puntos2=puntos2 +2;
         if(radioButton29.Checked == true)
                puntos2=puntos2 +3;
         if(radioButton35.Checked == true)
                puntos2=puntos2 +1;
         if(radioButton36.Checked == true) 
                puntos2=puntos2 +3;
         if(radioButton37.Checked == true)
                puntos2=puntos2 +4;
         if(radioButton42.Checked == true)
                puntos2 =puntos2 +3;

            cmd.ExecuteNonQuery();
            cn.Close();

            puntosfinales = puntos2 * 100 / 56;

            if (puntosfinales > 0 && puntosfinales <= 30)
                MessageBox.Show("Su grado de vulnerabilidad es baja" + " ya que su puntaje es de  " + (puntosfinales) + "%");

            if (puntosfinales >= 31 && puntosfinales <= 60)
                MessageBox.Show("Su grado de vulnerabilidad es media " + " ya que su puntaje es de  " + (puntosfinales) + "%");

            if (puntosfinales >= 61 && puntosfinales <= 80)
                MessageBox.Show("Su grado de vulnerabilidad es alta" + " ya que su puntaje es de  " + (puntosfinales) + "%");

            if (puntosfinales >= 81 && puntosfinales <= 100)
                MessageBox.Show("Su grado de vulnerabilidad es extrema" + " ya que su puntaje es de " + (puntosfinales) + "%");
            
            

            this.Close();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOTA: Subir dos imagenes," +
                " una cercana al hundimiento y otra con la que se puedan ver las dimensiones, por ejemplo un lapiz o cuaderno al lado del hundimiento");

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            if (dialogResult1 == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            if (dialogResult1 == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);

            }


        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton42.Checked == true)
                pictureBox4.Visible = true;



            else pictureBox4.Visible = false;

            if (radioButton42.Checked == true)
                pictureBox3.Visible = true;



            else pictureBox3.Visible = false;


            if (radioButton42.Checked == true)
                button28.Visible = true;



            else button28.Visible = false;

            if (radioButton42.Checked == true)
                button3.Visible = true;
            else button3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (radioButton42.Checked == true)
                this.Show();

        }

        private void botonmaposteria_CheckedChanged(object sender, EventArgs e)
        {
            if (botonmaposteria.Checked == true)
                panel3.Visible = true;
            else panel3.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
                panel4.Visible = true;
            else panel4.Visible = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
                panel5.Visible = true;
            else panel5.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOTA: Subir dos imagenes," +
               " una cercana a la grieta y otra con la que se puedan ver las dimensiones, por ejemplo un lapiz o cuaderno al lado de la grieta");
            button2.Enabled = false;
            if (radioButton37.Checked == true)
                button2.Enabled = true;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            if (dialogResult1 == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            if (dialogResult1 == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario1 = new mamposteria();
            formulario1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario1 = new tapia();
            formulario1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Mamposteriareforzada();
            formulario1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Mamposteriaconfinada();
            formulario1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Portico();
            formulario1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario1 = new prefabricado();
            formulario1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form formulario1 = new yeso();
            formulario1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formulario1 = new madera();
            formulario1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form formulario1 = new PVC();
            formulario1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form formulario1 = new drywall();
            formulario1.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form formulario1 = new fibrocemento();
            formulario1.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form formulario1 = new LosaAligerada();
            formulario1.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form formulario1 = new LosaMaciza();
            formulario1.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Zinc();
            formulario1.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Vigamadera();
            formulario1.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Vigaacero();
            formulario1.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form formulario1 = new LosaAligerada();
            formulario1.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form formulario1 = new LosaMaciza();
            formulario1.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Plancha();
            formulario1.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Placafacil();
            formulario1.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Eternit();
            formulario1.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Maderaybarro();
            formulario1.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Metalica();
            formulario1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
