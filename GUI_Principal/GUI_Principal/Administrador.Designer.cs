namespace GUI_Principal
{
    partial class Administrador
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
            this.Admin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(368, 204);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(35, 13);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "admin";
            this.Admin.Click += new System.EventHandler(this.label1_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admin);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
    }
}