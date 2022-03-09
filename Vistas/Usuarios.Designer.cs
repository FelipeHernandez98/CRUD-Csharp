
namespace PracticaCsharp.Vistas
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 86);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnInsertar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBuscador);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 39);
            this.panel2.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Blue;
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertar.Location = new System.Drawing.Point(249, 5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(97, 29);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticaCsharp.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(148, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBuscador
            // 
            this.textBuscador.Location = new System.Drawing.Point(12, 9);
            this.textBuscador.Name = "textBuscador";
            this.textBuscador.Size = new System.Drawing.Size(132, 20);
            this.textBuscador.TabIndex = 0;
            this.textBuscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(0, 86);
            this.dataListado.Name = "dataListado";
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(845, 379);
            this.dataListado.TabIndex = 1;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::PracticaCsharp.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::PracticaCsharp.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.buttonVolver);
            this.panelUsuario.Controls.Add(this.buttonGuardarCambios);
            this.panelUsuario.Controls.Add(this.buttonGuardar);
            this.panelUsuario.Controls.Add(this.pictureFoto);
            this.panelUsuario.Controls.Add(this.label4);
            this.panelUsuario.Controls.Add(this.textContrasena);
            this.panelUsuario.Controls.Add(this.textUsuario);
            this.panelUsuario.Controls.Add(this.label3);
            this.panelUsuario.Controls.Add(this.label2);
            this.panelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUsuario.Location = new System.Drawing.Point(179, 117);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(503, 300);
            this.panelUsuario.TabIndex = 2;
            this.panelUsuario.Visible = false;
            this.panelUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsuario_Paint);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(368, 250);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(86, 35);
            this.buttonVolver.TabIndex = 8;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Location = new System.Drawing.Point(218, 250);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(143, 35);
            this.buttonGuardarCambios.TabIndex = 7;
            this.buttonGuardarCambios.Text = "Guardar cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.buttonGuardarCambios_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(120, 250);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(92, 35);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // pictureFoto
            // 
            this.pictureFoto.Image = global::PracticaCsharp.Properties.Resources.user;
            this.pictureFoto.Location = new System.Drawing.Point(120, 134);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(109, 94);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFoto.TabIndex = 5;
            this.pictureFoto.TabStop = false;
            this.pictureFoto.Click += new System.EventHandler(this.pictureFoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Foto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textContrasena
            // 
            this.textContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textContrasena.Location = new System.Drawing.Point(116, 67);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.Size = new System.Drawing.Size(220, 26);
            this.textContrasena.TabIndex = 3;
            // 
            // textUsuario
            // 
            this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsuario.Location = new System.Drawing.Point(115, 28);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(221, 26);
            this.textUsuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cointraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dlg
            // 
            this.dlg.FileName = "openFileDialog1";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 465);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.panel1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBuscador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}