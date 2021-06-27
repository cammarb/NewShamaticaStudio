
namespace CapaPresentacion
{
    partial class FrmHorariosYSalas
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
            this.dgSalas = new System.Windows.Forms.DataGridView();
            this.dgHorarios = new System.Windows.Forms.DataGridView();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.tbxNombreSala = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HorarioPicker = new System.Windows.Forms.DateTimePicker();
            this.lblListado = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSalas
            // 
            this.dgSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalas.Location = new System.Drawing.Point(349, 100);
            this.dgSalas.Margin = new System.Windows.Forms.Padding(2);
            this.dgSalas.Name = "dgSalas";
            this.dgSalas.RowHeadersWidth = 51;
            this.dgSalas.RowTemplate.Height = 24;
            this.dgSalas.Size = new System.Drawing.Size(326, 122);
            this.dgSalas.TabIndex = 0;
            // 
            // dgHorarios
            // 
            this.dgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorarios.Location = new System.Drawing.Point(349, 272);
            this.dgHorarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgHorarios.Name = "dgHorarios";
            this.dgHorarios.RowHeadersWidth = 51;
            this.dgHorarios.RowTemplate.Height = 24;
            this.dgHorarios.Size = new System.Drawing.Size(326, 122);
            this.dgHorarios.TabIndex = 1;
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.ForeColor = System.Drawing.Color.White;
            this.lblRegistrar.Location = new System.Drawing.Point(44, 121);
            this.lblRegistrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(109, 19);
            this.lblRegistrar.TabIndex = 2;
            this.lblRegistrar.Text = "Nombre Sala:";
            // 
            // tbxNombreSala
            // 
            this.tbxNombreSala.Location = new System.Drawing.Point(157, 120);
            this.tbxNombreSala.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNombreSala.Name = "tbxNombreSala";
            this.tbxNombreSala.Size = new System.Drawing.Size(151, 20);
            this.tbxNombreSala.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(48, 186);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 36);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(200, 186);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrarHorario
            // 
            this.btnRegistrarHorario.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarHorario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarHorario.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarHorario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarHorario.Location = new System.Drawing.Point(51, 358);
            this.btnRegistrarHorario.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarHorario.Name = "btnRegistrarHorario";
            this.btnRegistrarHorario.Size = new System.Drawing.Size(103, 36);
            this.btnRegistrarHorario.TabIndex = 6;
            this.btnRegistrarHorario.Text = "Agregar";
            this.btnRegistrarHorario.UseVisualStyleBackColor = false;
            this.btnRegistrarHorario.Click += new System.EventHandler(this.btnRegistrarHorario_Click);
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarHorario.FlatAppearance.BorderSize = 0;
            this.btnEliminarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHorario.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHorario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarHorario.Location = new System.Drawing.Point(200, 358);
            this.btnEliminarHorario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(108, 36);
            this.btnEliminarHorario.TabIndex = 7;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = false;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Horario:";
            // 
            // HorarioPicker
            // 
            this.HorarioPicker.CustomFormat = "hh:00 tt";
            this.HorarioPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HorarioPicker.Location = new System.Drawing.Point(157, 312);
            this.HorarioPicker.Margin = new System.Windows.Forms.Padding(2);
            this.HorarioPicker.Name = "HorarioPicker";
            this.HorarioPicker.ShowUpDown = true;
            this.HorarioPicker.Size = new System.Drawing.Size(151, 20);
            this.HorarioPicker.TabIndex = 9;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.Transparent;
            this.lblListado.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.White;
            this.lblListado.Location = new System.Drawing.Point(24, 27);
            this.lblListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(416, 35);
            this.lblListado.TabIndex = 10;
            this.lblListado.Text = "Listado de clientes registrados";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightCoral;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(551, 424);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 53);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmHorariosYSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 510);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.HorarioPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.btnRegistrarHorario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbxNombreSala);
            this.Controls.Add(this.lblRegistrar);
            this.Controls.Add(this.dgHorarios);
            this.Controls.Add(this.dgSalas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHorariosYSalas";
            this.Text = "FrmHorariosYSalas";
            this.Load += new System.EventHandler(this.FrmHorariosYSalas_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmHorariosYSalas_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSalas;
        private System.Windows.Forms.DataGridView dgHorarios;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.TextBox tbxNombreSala;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrarHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HorarioPicker;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Button btnVolver;
    }
}