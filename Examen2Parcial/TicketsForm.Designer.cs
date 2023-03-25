namespace Examen2Parcial
{
    partial class TicketsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoUsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.TipoSoporteComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RespuestaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SolicitudTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ImpuestoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(751, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente:";
            // 
            // CodigoUsuarioTextBox1
            // 
            this.CodigoUsuarioTextBox1.Location = new System.Drawing.Point(80, 42);
            this.CodigoUsuarioTextBox1.Name = "CodigoUsuarioTextBox1";
            this.CodigoUsuarioTextBox1.Size = new System.Drawing.Size(180, 20);
            this.CodigoUsuarioTextBox1.TabIndex = 4;
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(486, 41);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(180, 20);
            this.ClienteTextBox.TabIndex = 5;
            // 
            // TipoSoporteComboBox
            // 
            this.TipoSoporteComboBox.FormattingEnabled = true;
            this.TipoSoporteComboBox.Items.AddRange(new object[] {
            "Reparacion de Celulares",
            "Reparacion de Equipos de Computo"});
            this.TipoSoporteComboBox.Location = new System.Drawing.Point(125, 25);
            this.TipoSoporteComboBox.Name = "TipoSoporteComboBox";
            this.TipoSoporteComboBox.Size = new System.Drawing.Size(255, 21);
            this.TipoSoporteComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Soporte:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RespuestaTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SolicitudTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TipoSoporteComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 249);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soporte";
            // 
            // RespuestaTextBox
            // 
            this.RespuestaTextBox.Location = new System.Drawing.Point(572, 80);
            this.RespuestaTextBox.Multiline = true;
            this.RespuestaTextBox.Name = "RespuestaTextBox";
            this.RespuestaTextBox.Size = new System.Drawing.Size(255, 106);
            this.RespuestaTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Respuesta:";
            // 
            // SolicitudTextBox
            // 
            this.SolicitudTextBox.Location = new System.Drawing.Point(125, 80);
            this.SolicitudTextBox.Multiline = true;
            this.SolicitudTextBox.Name = "SolicitudTextBox";
            this.SolicitudTextBox.Size = new System.Drawing.Size(255, 106);
            this.SolicitudTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Solicitud:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.DescuentoTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ImpuestoTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.PrecioTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(698, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 140);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura";
            // 
            // TotalextBox
            // 
            this.TotalextBox.Location = new System.Drawing.Point(94, 113);
            this.TotalextBox.Name = "TotalextBox";
            this.TotalextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total:";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(94, 71);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescuentoTextBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descuento:";
            // 
            // ImpuestoTextBox
            // 
            this.ImpuestoTextBox.Location = new System.Drawing.Point(94, 44);
            this.ImpuestoTextBox.Name = "ImpuestoTextBox";
            this.ImpuestoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImpuestoTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Impuesto:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(94, 18);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio:";
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.CodigoUsuarioTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "TicketsForm";
            this.Text = "TicketsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoUsuarioTextBox1;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.ComboBox TipoSoporteComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SolicitudTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RespuestaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TotalextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ImpuestoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label7;
    }
}