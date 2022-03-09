using PracticaCsharp.Datos;
using PracticaCsharp.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticaCsharp.Vistas
{
    public partial class Usuarios : Form
    {
        int idusuario;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            mostrar_usuarios();
        }

        private void mostrar_usuarios()
        {
            DataTable dt;
            datoUsuario funcion = new datoUsuario();
            dt = funcion.mostrar_usuarios();
            dataListado.DataSource = dt;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscar_usuarios();
        }

        private void buscar_usuarios()
        {
            DataTable dt;
            datoUsuario funcion = new datoUsuario();
            dt = funcion.buscar_usuarios(textBuscador.Text);
            dataListado.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = true;
            panelUsuario.Dock = DockStyle.Fill;
            buttonGuardar.Visible = true;
            buttonGuardarCambios.Visible = false;
            textUsuario.Clear();
            textContrasena.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureFoto_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes | *.jpg; *.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargar imagenes";
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                pictureFoto.BackgroundImage = null;
                pictureFoto.Image = new Bitmap(dlg.FileName);

            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != "")
            {
                if(textContrasena.Text != "")
                {
                    insertar_usuario();
                    mostrar_usuarios();
                }
                else
                {
                    MessageBox.Show("Ingrese la contraseña", "Sin contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el usuario", "Sin usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertar_usuario()
        {
            logicaUsuarios dt = new logicaUsuarios();
            datoUsuario funcion = new datoUsuario();
            dt.Usuario = textUsuario.Text;
            dt.Contraseña = textContrasena.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureFoto.Image.Save(ms, pictureFoto.Image.RawFormat);
            dt.Icono = ms.GetBuffer();
            dt.Estado = "Activo";
            if (funcion.insertar(dt))
            {
                MessageBox.Show("Usuario creado correctamente", "Registro exitoso!");
                panelUsuario.Visible = false;
                panelUsuario.Dock = DockStyle.None;
            }

        }

        public void eliminar_usuarios()
        {
            logicaUsuarios dt = new logicaUsuarios();
            datoUsuario funcion = new datoUsuario();
            dt.Id_usuario = idusuario;
            if (funcion.eliminar_usuarios(dt))
            {
                MessageBox.Show("Usuario eliminado", "Eliminación correcta");
                panelUsuario.Visible = false;
                panelUsuario.Dock = DockStyle.None;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idusuario = Convert.ToInt32(dataListado.SelectedCells[2].Value.ToString());

            if(e.ColumnIndex == this.dataListado.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Esta seguro de que desea eliminar usuario?", "Eliminando usuario", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    eliminar_usuarios();
                    mostrar_usuarios();
                }
            }

            if(e.ColumnIndex == this.dataListado.Columns["Editar"].Index){
                
                textUsuario.Text = dataListado.SelectedCells[3].Value.ToString();
                textContrasena.Text = dataListado.SelectedCells[4].Value.ToString();
                pictureFoto.BackgroundImage = null;
                byte[] b = (Byte[])dataListado.SelectedCells[5].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(b);
                pictureFoto.Image = Image.FromStream(ms);
                panelUsuario.Visible = true;
                panelUsuario.Dock = DockStyle.Fill;
                buttonGuardar.Visible = false;
                buttonGuardarCambios.Visible = true;



            }
        }

        private void panelUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
            panelUsuario.Dock = DockStyle.None;
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            editar_usuario();
            mostrar_usuarios();
        }

        private void editar_usuario()
        {
            logicaUsuarios dt = new logicaUsuarios();
            datoUsuario funcion = new datoUsuario();
            dt.Id_usuario = idusuario;
            dt.Usuario = textUsuario.Text;
            dt.Contraseña = textContrasena.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureFoto.Image.Save(ms, pictureFoto.Image.RawFormat);
            dt.Icono = ms.GetBuffer();
            dt.Estado = "Activo";
            if (funcion.editar(dt))
            {
                MessageBox.Show("Usuario editado correctamente", "Registro exitoso!");
                panelUsuario.Visible = false;
                panelUsuario.Dock = DockStyle.None;
            }

        }
    }
}
