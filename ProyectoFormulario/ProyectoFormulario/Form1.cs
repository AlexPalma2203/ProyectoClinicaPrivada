using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == ".:.USUARIO.:.") {
                Usuario.Text = "";
                Usuario.ForeColor = Color.LightGray;
            } 
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text=="") {
                Usuario.Text = ".:.USUARIO.:.";
                Usuario.ForeColor = Color.DimGray;
            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == ".:.CONTRASEÑA.:.")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Color.LightGray;
                Contraseña.UseSystemPasswordChar = true;
            }

        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = ".:.CONTRASEÑA.:.";
                Contraseña.ForeColor = Color.DimGray;
                Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
