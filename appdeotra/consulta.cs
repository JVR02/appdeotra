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
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
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


        private void consulta_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //iNNER JOIN form3 ON formregistros.ID_form = form3.fk_id_user
            cn.Open();
            string consultar = "(SELECT nombre, apellido,celular, correo, cedula, direccion, unidad, departamento, municipio, barrio FROM formregistros WHERE ID_form = Txt_id) values('" + a + "','" + ee + "', '" + c + "','" + d + "','" + b + "','" + f + "','" + g + "','" + h + "', '" + i + "','" + j + "', '" + k + "')";
            MySqlCommand cmd = new MySqlCommand(consultar,cn);


            Lbl_nombre.Text = Convert.ToString(a);
            Lbl_apellido.Text = Convert.ToString(ee);
            Lbl_celular.Text = Convert.ToString(c);
            Lbl_correo.Text = Convert.ToString(d);
            Lbl_cedula.Text = Convert.ToString(f);
            Lbl_direccion.Text = Convert.ToString(g);
            Lbl_unidad.Text = Convert.ToString(h);
            Lbl_departamento.Text= Convert.ToString(i);
            Lbl_Municipio.Text = Convert.ToString(j);
            Lbl_barrio.Text= Convert.ToString(k);
            //Lbl_Nivel.Text= Convert.ToString(l);
            //Lbl_contruccion = Convert.ToString(m);
            //Lbl_empresa.Text = Convert.ToString(n);



        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void Lbl_contruccion_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Nivel_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_barrio_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Municipio_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_departamento_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_unidad_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_direccion_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_cedula_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_correo_Click(object sender, EventArgs e)
        {

        }
    }
}
