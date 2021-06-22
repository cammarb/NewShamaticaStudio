
namespace CapaPresentacion
{
    partial class FrmGestionInstrumentos
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
            this.tbxCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgInstrumentos = new System.Windows.Forms.DataGridView();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxCosto
            // 
            this.tbxCosto.Location = new System.Drawing.Point(172, 123);
            this.tbxCosto.Name = "tbxCosto";
            this.tbxCosto.Size = new System.Drawing.Size(236, 22);
            this.tbxCosto.TabIndex = 27;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(22, 126);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(44, 17);
            this.lblCosto.TabIndex = 26;
            this.lblCosto.Text = "Costo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(333, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(172, 182);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(25, 183);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgInstrumentos
            // 
            this.dgInstrumentos.AllowUserToAddRows = false;
            this.dgInstrumentos.AllowUserToDeleteRows = false;
            this.dgInstrumentos.AllowUserToResizeColumns = false;
            this.dgInstrumentos.AllowUserToResizeRows = false;
            this.dgInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstrumentos.Location = new System.Drawing.Point(462, 55);
            this.dgInstrumentos.Name = "dgInstrumentos";
            this.dgInstrumentos.RowHeadersWidth = 51;
            this.dgInstrumentos.RowTemplate.Height = 24;
            this.dgInstrumentos.Size = new System.Drawing.Size(389, 190);
            this.dgInstrumentos.TabIndex = 22;
            this.dgInstrumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstrumentos_CellClick);
            this.dgInstrumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstrumentos_CellContentClick);
            this.dgInstrumentos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgInstrumentos_ColumnHeaderMouseClick);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(172, 81);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(236, 22);
            this.tbxNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // FrmGestionInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 300);
            this.Controls.Add(this.tbxCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgInstrumentos);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmGestionInstrumentos";
            this.Text = "FrmGestionInstrumentos";
            this.Load += new System.EventHandler(this.FrmGestionInstrumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgInstrumentos;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}