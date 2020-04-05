namespace AplicacionArchivoEmpleado.GUIInterfaz
{
    partial class GUIMostrarEnGrilla
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
            this.grillaMostrar = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.button1Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaMostrar
            // 
            this.grillaMostrar.ColumnHeadersHeight = 40;
            this.grillaMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Telefono,
            this.Direccion});
            this.grillaMostrar.Location = new System.Drawing.Point(60, 79);
            this.grillaMostrar.Name = "grillaMostrar";
            this.grillaMostrar.RowHeadersWidth = 72;
            this.grillaMostrar.Size = new System.Drawing.Size(1062, 566);
            this.grillaMostrar.TabIndex = 0;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 9;
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 175;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 9;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 175;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 9;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 175;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 9;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 175;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(859, 667);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(148, 50);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // button1Salir
            // 
            this.button1Salir.Location = new System.Drawing.Point(159, 667);
            this.button1Salir.Name = "button1Salir";
            this.button1Salir.Size = new System.Drawing.Size(147, 50);
            this.button1Salir.TabIndex = 2;
            this.button1Salir.Text = "Salir";
            this.button1Salir.UseVisualStyleBackColor = true;
            this.button1Salir.Click += new System.EventHandler(this.button1Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DE EMPLEADOS";
            // 
            // GUIMostrarEnGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1183, 773);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Salir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.grillaMostrar);
            this.Name = "GUIMostrarEnGrilla";
            this.Text = "GUIMostrarEnGrilla";
            ((System.ComponentModel.ISupportInitialize)(this.grillaMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button button1Salir;
        private System.Windows.Forms.Label label1;
    }
}