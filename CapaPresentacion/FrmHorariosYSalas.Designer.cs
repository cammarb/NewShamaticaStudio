
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
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSalas
            // 
            this.dgSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalas.Location = new System.Drawing.Point(363, 43);
            this.dgSalas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgSalas.Name = "dgSalas";
            this.dgSalas.RowHeadersWidth = 51;
            this.dgSalas.RowTemplate.Height = 24;
            this.dgSalas.Size = new System.Drawing.Size(326, 122);
            this.dgSalas.TabIndex = 0;
            // 
            // dgHorarios
            // 
            this.dgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorarios.Location = new System.Drawing.Point(363, 215);
            this.dgHorarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgHorarios.Name = "dgHorarios";
            this.dgHorarios.RowHeadersWidth = 51;
            this.dgHorarios.RowTemplate.Height = 24;
            this.dgHorarios.Size = new System.Drawing.Size(326, 122);
            this.dgHorarios.TabIndex = 1;
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Location = new System.Drawing.Point(98, 69);
            this.lblRegistrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(68, 13);
            this.lblRegistrar.TabIndex = 2;
            this.lblRegistrar.Text = "Agregar Sala";
            // 
            // tbxNombreSala
            // 
            this.tbxNombreSala.Location = new System.Drawing.Point(170, 66);
            this.tbxNombreSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxNombreSala.Name = "tbxNombreSala";
            this.tbxNombreSala.Size = new System.Drawing.Size(151, 20);
            this.tbxNombreSala.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(85, 129);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 36);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(213, 129);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrarHorario
            // 
            this.btnRegistrarHorario.Location = new System.Drawing.Point(85, 301);
            this.btnRegistrarHorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarHorario.Name = "btnRegistrarHorario";
            this.btnRegistrarHorario.Size = new System.Drawing.Size(103, 36);
            this.btnRegistrarHorario.TabIndex = 6;
            this.btnRegistrarHorario.Text = "Agregar";
            this.btnRegistrarHorario.UseVisualStyleBackColor = true;
            this.btnRegistrarHorario.Click += new System.EventHandler(this.btnRegistrarHorario_Click);
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Location = new System.Drawing.Point(213, 301);
            this.btnEliminarHorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(108, 36);
            this.btnEliminarHorario.TabIndex = 7;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Horario:";
            // 
            // HorarioPicker
            // 
            this.HorarioPicker.CustomFormat = "hh:00 tt";
            this.HorarioPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HorarioPicker.Location = new System.Drawing.Point(170, 256);
            this.HorarioPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HorarioPicker.Name = "HorarioPicker";
            this.HorarioPicker.ShowUpDown = true;
            this.HorarioPicker.Size = new System.Drawing.Size(151, 20);
            this.HorarioPicker.TabIndex = 9;
            // 
            // FrmHorariosYSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHorariosYSalas";
            this.Text = "FrmHorariosYSalas";
            this.Load += new System.EventHandler(this.FrmHorariosYSalas_Load);
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
    }
}