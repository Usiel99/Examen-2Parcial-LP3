namespace Examen2Parcial
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.CodigoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoUsuarioTextBox
            // 
            this.CodigoUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoUsuarioTextBox.Location = new System.Drawing.Point(124, 136);
            this.CodigoUsuarioTextBox.Name = "CodigoUsuarioTextBox";
            this.CodigoUsuarioTextBox.Size = new System.Drawing.Size(174, 21);
            this.CodigoUsuarioTextBox.TabIndex = 2;
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaTextBox.Location = new System.Drawing.Point(124, 162);
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.PasswordChar = '*';
            this.ContrasenaTextBox.Size = new System.Drawing.Size(174, 21);
            this.ContrasenaTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.Image = global::Examen2Parcial.Properties.Resources.cheque;
            this.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButton.Location = new System.Drawing.Point(37, 216);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(96, 32);
            this.AceptarButton.TabIndex = 0;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::Examen2Parcial.Properties.Resources.cruz;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.Location = new System.Drawing.Point(161, 216);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(102, 32);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Image = global::Examen2Parcial.Properties.Resources.user_interface;
            this.ImagenPictureBox.Location = new System.Drawing.Point(124, 12);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(99, 95);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 6;
            this.ImagenPictureBox.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(333, 300);
            this.ControlBox = false;
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.CodigoUsuarioTextBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.TextBox CodigoUsuarioTextBox;
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

