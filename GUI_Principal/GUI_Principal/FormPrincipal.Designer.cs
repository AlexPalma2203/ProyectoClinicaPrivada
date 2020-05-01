namespace GUI_Principal
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Contenedor = new System.Windows.Forms.Panel();
            this.Formularios = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.Administracion = new System.Windows.Forms.Button();
            this.Enfermera = new System.Windows.Forms.Button();
            this.Medico = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.Close = new FontAwesome.Sharp.IconPictureBox();
            this.Contenedor.SuspendLayout();
            this.Menu.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Contenedor.Controls.Add(this.Formularios);
            this.Contenedor.Controls.Add(this.Menu);
            this.Contenedor.Controls.Add(this.BarraTitulo);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1036, 536);
            this.Contenedor.TabIndex = 0;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Formularios
            // 
            this.Formularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.Formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formularios.Location = new System.Drawing.Point(244, 38);
            this.Formularios.Name = "Formularios";
            this.Formularios.Size = new System.Drawing.Size(792, 498);
            this.Formularios.TabIndex = 0;
            this.Formularios.Paint += new System.Windows.Forms.PaintEventHandler(this.Formularios_Paint);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Menu.Controls.Add(this.Administracion);
            this.Menu.Controls.Add(this.Enfermera);
            this.Menu.Controls.Add(this.Medico);
            this.Menu.Controls.Add(this.shapeContainer1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 38);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(244, 498);
            this.Menu.TabIndex = 1;
            // 
            // Administracion
            // 
            this.Administracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Administracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Administracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administracion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administracion.ForeColor = System.Drawing.Color.DimGray;
            this.Administracion.Location = new System.Drawing.Point(0, 323);
            this.Administracion.Name = "Administracion";
            this.Administracion.Size = new System.Drawing.Size(244, 37);
            this.Administracion.TabIndex = 3;
            this.Administracion.Text = "Administracion";
            this.Administracion.UseVisualStyleBackColor = false;
            this.Administracion.Click += new System.EventHandler(this.Administracion_Click);
            // 
            // Enfermera
            // 
            this.Enfermera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Enfermera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enfermera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enfermera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enfermera.ForeColor = System.Drawing.Color.Gray;
            this.Enfermera.Location = new System.Drawing.Point(0, 222);
            this.Enfermera.Name = "Enfermera";
            this.Enfermera.Size = new System.Drawing.Size(244, 37);
            this.Enfermera.TabIndex = 2;
            this.Enfermera.Text = "Enfermera";
            this.Enfermera.UseVisualStyleBackColor = false;
            this.Enfermera.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medico
            // 
            this.Medico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Medico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medico.ForeColor = System.Drawing.Color.DimGray;
            this.Medico.Location = new System.Drawing.Point(0, 125);
            this.Medico.Name = "Medico";
            this.Medico.Size = new System.Drawing.Size(244, 37);
            this.Medico.TabIndex = 1;
            this.Medico.Text = "Medico";
            this.Medico.UseVisualStyleBackColor = false;
            this.Medico.Click += new System.EventHandler(this.Citas_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(244, 498);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ControlText;
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 255;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.BarraTitulo.Controls.Add(this.Minimizar);
            this.BarraTitulo.Controls.Add(this.Close);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1036, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.ForeColor = System.Drawing.Color.DimGray;
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.Minimizar.IconColor = System.Drawing.Color.DimGray;
            this.Minimizar.Location = new System.Drawing.Point(963, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.iconPictureBox1_Click_1);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.ForeColor = System.Drawing.Color.DimGray;
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close.IconColor = System.Drawing.Color.DimGray;
            this.Close.Location = new System.Drawing.Point(1001, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 536);
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Contenedor.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel Formularios;
        private FontAwesome.Sharp.IconPictureBox Close;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button Medico;
        private System.Windows.Forms.Button Administracion;
        private System.Windows.Forms.Button Enfermera;
    }
}

