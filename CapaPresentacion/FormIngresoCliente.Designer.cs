
namespace CapaPresentacion
{
    partial class FormIngresoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDNILoginCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraLoginCliente = new System.Windows.Forms.TextBox();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(131, 130);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 18);
            this.lblDni.TabIndex = 30;
            this.lblDni.Text = "DNI:";
            // 
            // txtDNILoginCliente
            // 
            this.txtDNILoginCliente.Location = new System.Drawing.Point(134, 159);
            this.txtDNILoginCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNILoginCliente.Name = "txtDNILoginCliente";
            this.txtDNILoginCliente.Size = new System.Drawing.Size(166, 20);
            this.txtDNILoginCliente.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Contraseña:";
            // 
            // txtContraLoginCliente
            // 
            this.txtContraLoginCliente.Location = new System.Drawing.Point(134, 240);
            this.txtContraLoginCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraLoginCliente.Name = "txtContraLoginCliente";
            this.txtContraLoginCliente.Size = new System.Drawing.Size(166, 20);
            this.txtContraLoginCliente.TabIndex = 40;
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresarCliente.FlatAppearance.BorderSize = 0;
            this.btnIngresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarCliente.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCliente.ForeColor = System.Drawing.Color.White;
            this.btnIngresarCliente.Location = new System.Drawing.Point(134, 302);
            this.btnIngresarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(166, 46);
            this.btnIngresarCliente.TabIndex = 52;
            this.btnIngresarCliente.Text = "Ingresar";
            this.btnIngresarCliente.UseVisualStyleBackColor = false;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // FormIngresoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(440, 404);
            this.Controls.Add(this.btnIngresarCliente);
            this.Controls.Add(this.txtContraLoginCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNILoginCliente);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormIngresoCliente";
            this.Text = "FormIngresoCliente";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormIngresoCliente_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDNILoginCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraLoginCliente;
        private System.Windows.Forms.Button btnIngresarCliente;
    }
}