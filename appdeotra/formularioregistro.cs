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
    public partial class formularioregistro : Form
    {
        public formularioregistro()
        {
            InitializeComponent();
        }
        static string conexion = "SERVER= 127.0.0.1;DATABASE=civil;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void formularioregistro_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            string insertar = "INSERT INTO formregistros (nombre,apellido,celular,correo,cedula,direccion,unidad,departamento,municipio,barrio)values(@nombre,@apellido,@celular,@correo,@cedula," +
                "@direccion,@unidad,@departamento,@municipio,@barrio)";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);






            cmd.Parameters.AddWithValue("nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("apellido", txtapellido.Text);
            cmd.Parameters.AddWithValue("celular", txtcelular.Text);
            cmd.Parameters.AddWithValue("correo", txtcorreo.Text);
            cmd.Parameters.AddWithValue("cedula", txtcedula.Text);
            cmd.Parameters.AddWithValue("direccion", txtdireccion.Text);
            cmd.Parameters.AddWithValue("unidad", txtunidad.Text);
            cmd.Parameters.AddWithValue("departamento", txtdepartamento.Text);
            cmd.Parameters.AddWithValue("municipio", txtmunicipio.Text);
            cmd.Parameters.AddWithValue("barrio", txtbarrio.Text);

            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Datos guardados de manera exitosa ");

            this.Hide();
            Form formulario1 = new form3();
            formulario1.Show();
            MessageBox.Show("Gracias por la informacion suministrada, ahora empezaremos con nuestro formulario, lee detenidamente cada pregunta.   ");

        }
        void activar_boton()
        {
            button1.Enabled = true;
        }

        void desactivar_boton()
            {
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Aceptando terminos y condiciones");

            if (checkBox1.Checked == true)
            {
                activar_boton();
            }
            else
            {
                desactivar_boton();
            }

            if(checkBox1.Checked == true)
                button1.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
