namespace ProyectoFormulario
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Acceder = new System.Windows.Forms.Button();
            this.Recuperar = new System.Windows.Forms.LinkLabel();
            this.Close = new FontAwesome.Sharp.IconPictureBox();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 217;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 64);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(340, 217);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.GrayText;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 280;
            this.lineShape2.X2 = 747;
            this.lineShape2.Y1 = 174;
            this.lineShape2.Y2 = 174;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.GrayText;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 279;
            this.lineShape1.X2 = 746;
            this.lineShape1.Y1 = 90;
            this.lineShape1.Y2 = 90;
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.Usuario.Location = new System.Drawing.Point(279, 67);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(468, 20);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = ".:.USUARIO.:.";
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.Contraseña.Location = new System.Drawing.Point(279, 152);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(468, 20);
            this.Contraseña.TabIndex = 2;
            this.Contraseña.Text = ".:.CONTRASEÑA.:.";
            this.Contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.Contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(452, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Acceder
            // 
            this.Acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Acceder.FlatAppearance.BorderSize = 0;
            this.Acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acceder.ForeColor = System.Drawing.Color.DimGray;
            this.Acceder.Location = new System.Drawing.Point(279, 241);
            this.Acceder.Name = "Acceder";
            this.Acceder.Size = new System.Drawing.Size(467, 40);
            this.Acceder.TabIndex = 3;
            this.Acceder.Text = "ACCEDER";
            this.Acceder.UseVisualStyleBackColor = false;
            // 
            // Recuperar
            // 
            this.Recuperar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(170)))), ((int)(((byte)(154)))));
            this.Recuperar.AutoSize = true;
            this.Recuperar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recuperar.LinkColor = System.Drawing.Color.DimGray;
            this.Recuperar.Location = new System.Drawing.Point(444, 293);
            this.Recuperar.Name = "Recuperar";
            this.Recuperar.Size = new System.Drawing.Size(129, 15);
            this.Recuperar.TabIndex = 0;
            this.Recuperar.TabStop = true;
            this.Recuperar.Text = "Recuperar Contraseña";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Close.ForeColor = System.Drawing.Color.DimGray;
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close.IconColor = System.Drawing.Color.DimGray;
            this.Close.Location = new System.Drawing.Point(745, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Close.TabIndex = 8;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Minimizar.ForeColor = System.Drawing.Color.DimGray;
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.Minimizar.IconColor = System.Drawing.Color.DimGray;
            this.Minimizar.Location = new System.Drawing.Point(707, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Minimizar.TabIndex = 9;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Recuperar);
            this.Controls.Add(this.Acceder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:. Ingreso De Usuario .:.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Acceder;
        private System.Windows.Forms.LinkLabel Recuperar;
        private FontAwesome.Sharp.IconPictureBox Close;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

