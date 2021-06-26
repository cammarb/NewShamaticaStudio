
namespace CapaPresentacion
{
    partial class FormPantallaCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnRealizarReserva = new System.Windows.Forms.Button();
            this.btnVerReservas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 48);
            this.label1.TabIndex = 32;
            this.label1.Text = "Menu de cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 33;
            this.label2.Text = "Reservas";
            // 
            // btnRealizarReserva
            // 
            this.btnRealizarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRealizarReserva.FlatAppearance.BorderSize = 0;
            this.btnRealizarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarReserva.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarReserva.ForeColor = System.Drawing.Color.White;
            this.btnRealizarReserva.Location = new System.Drawing.Point(153, 193);
            this.btnRealizarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizarReserva.Name = "btnRealizarReserva";
            this.btnRealizarReserva.Size = new System.Drawing.Size(187, 68);
            this.btnRealizarReserva.TabIndex = 34;
            this.btnRealizarReserva.Text = "Realizar Reserva";
            this.btnRealizarReserva.UseVisualStyleBackColor = false;
            this.btnRealizarReserva.Click += new System.EventHandler(this.btnRealizarReserva_Click);
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerReservas.FlatAppearance.BorderSize = 0;
            this.btnVerReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReservas.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReservas.ForeColor = System.Drawing.Color.White;
            this.btnVerReservas.Location = new System.Drawing.Point(153, 303);
            this.btnVerReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.Size = new System.Drawing.Size(187, 68);
            this.btnVerReservas.TabIndex = 35;
            this.btnVerReservas.Text = "Ver Reservas";
            this.btnVerReservas.UseVisualStyleBackColor = false;
            this.btnVerReservas.Click += new System.EventHandler(this.btnVerReservas_Click);
            // 
            // FormPantallaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.btnVerReservas);
            this.Controls.Add(this.btnRealizarReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPantallaCliente";
            this.Text = "FormPantallaCliente";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPantallaCliente_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRealizarReserva;
        private System.Windows.Forms.Button btnVerReservas;
    }
}