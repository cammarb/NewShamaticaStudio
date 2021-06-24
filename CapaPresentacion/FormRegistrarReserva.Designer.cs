
namespace CapaPresentacion
{
    partial class FormRegistrarReserva
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
            this.btnRegistrarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Horario = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraLoginCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNILoginCliente = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarReserva
            // 
            this.btnRegistrarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarReserva.FlatAppearance.BorderSize = 0;
            this.btnRegistrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarReserva.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarReserva.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarReserva.Location = new System.Drawing.Point(626, 545);
            this.btnRegistrarReserva.Name = "btnRegistrarReserva";
            this.btnRegistrarReserva.Size = new System.Drawing.Size(249, 71);
            this.btnRegistrarReserva.TabIndex = 58;
            this.btnRegistrarReserva.Text = "Registrar";
            this.btnRegistrarReserva.UseVisualStyleBackColor = false;
            this.btnRegistrarReserva.Click += new System.EventHandler(this.btnRegistrarReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 58);
            this.label1.TabIndex = 53;
            this.label1.Text = "Registrar reserva";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 26);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // Horario
            // 
            this.Horario.FormattingEnabled = true;
            this.Horario.ItemHeight = 20;
            this.Horario.Location = new System.Drawing.Point(130, 323);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(289, 184);
            this.Horario.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 61;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(126, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 62;
            this.label3.Text = "Horario";
            // 
            // txtContraLoginCliente
            // 
            this.txtContraLoginCliente.Location = new System.Drawing.Point(626, 443);
            this.txtContraLoginCliente.Name = "txtContraLoginCliente";
            this.txtContraLoginCliente.Size = new System.Drawing.Size(247, 26);
            this.txtContraLoginCliente.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(621, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 65;
            this.label4.Text = "Contraseña:";
            // 
            // txtDNILoginCliente
            // 
            this.txtDNILoginCliente.Location = new System.Drawing.Point(626, 319);
            this.txtDNILoginCliente.Name = "txtDNILoginCliente";
            this.txtDNILoginCliente.Size = new System.Drawing.Size(247, 26);
            this.txtDNILoginCliente.TabIndex = 64;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(621, 274);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(56, 26);
            this.lblDni.TabIndex = 63;
            this.lblDni.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(621, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Confirmar DNI y contraseña";
            // 
            // FormRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 671);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraLoginCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDNILoginCliente);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRegistrarReserva);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrarReserva";
            this.Text = "FormRegistrarReserva";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormRegistrarReserva_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox Horario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraLoginCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNILoginCliente;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label5;
    }
}