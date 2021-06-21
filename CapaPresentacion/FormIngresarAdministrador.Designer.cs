
namespace CapaPresentacion
{
    partial class FormIngresarAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresarAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDNIIngresoAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraIngresoAdmin = new System.Windows.Forms.TextBox();
            this.btnIngresarAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ingreso Administrador";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(66, 86);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(46, 24);
            this.lblDni.TabIndex = 31;
            this.lblDni.Text = "DNI:";
            // 
            // txtDNIIngresoAdmin
            // 
            this.txtDNIIngresoAdmin.Location = new System.Drawing.Point(110, 122);
            this.txtDNIIngresoAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNIIngresoAdmin.Name = "txtDNIIngresoAdmin";
            this.txtDNIIngresoAdmin.Size = new System.Drawing.Size(163, 22);
            this.txtDNIIngresoAdmin.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Contraseña:";
            // 
            // txtContraIngresoAdmin
            // 
            this.txtContraIngresoAdmin.Location = new System.Drawing.Point(110, 202);
            this.txtContraIngresoAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraIngresoAdmin.Name = "txtContraIngresoAdmin";
            this.txtContraIngresoAdmin.Size = new System.Drawing.Size(163, 22);
            this.txtContraIngresoAdmin.TabIndex = 42;
            // 
            // btnIngresarAdmin
            // 
            this.btnIngresarAdmin.BackColor = System.Drawing.Color.Black;
            this.btnIngresarAdmin.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIngresarAdmin.Location = new System.Drawing.Point(306, 230);
            this.btnIngresarAdmin.Name = "btnIngresarAdmin";
            this.btnIngresarAdmin.Size = new System.Drawing.Size(222, 118);
            this.btnIngresarAdmin.TabIndex = 54;
            this.btnIngresarAdmin.Text = "Ingresar";
            this.btnIngresarAdmin.UseVisualStyleBackColor = false;
            this.btnIngresarAdmin.Click += new System.EventHandler(this.btnIngresarAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // FormIngresarAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(682, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresarAdmin);
            this.Controls.Add(this.txtContraIngresoAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNIIngresoAdmin);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label1);
            this.Name = "FormIngresarAdministrador";
            this.Text = "FormIngresarAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDNIIngresoAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraIngresoAdmin;
        private System.Windows.Forms.Button btnIngresarAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}