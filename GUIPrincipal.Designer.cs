namespace AplicacionArchivoEmpleado
{
    partial class GUIPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarGrillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(860, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarGrillaToolStripMenuItem,
            this.registrarEmpleadoToolStripMenuItem,
            this.eliminarEmpleadoToolStripMenuItem,
            this.modificarEmpleadoToolStripMenuItem,
            this.buscarEmpleadoToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // mostrarGrillaToolStripMenuItem
            // 
            this.mostrarGrillaToolStripMenuItem.Name = "mostrarGrillaToolStripMenuItem";
            this.mostrarGrillaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.mostrarGrillaToolStripMenuItem.Text = "Mostrar Empleados";
            this.mostrarGrillaToolStripMenuItem.Click += new System.EventHandler(this.mostrarGrillaToolStripMenuItem_Click);
            // 
            // registrarEmpleadoToolStripMenuItem
            // 
            this.registrarEmpleadoToolStripMenuItem.Name = "registrarEmpleadoToolStripMenuItem";
            this.registrarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.registrarEmpleadoToolStripMenuItem.Text = "Registrar Empleado";
            this.registrarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadoToolStripMenuItem_Click);
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
            this.eliminarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarEmpleadoToolStripMenuItem_Click);
            // 
            // modificarEmpleadoToolStripMenuItem
            // 
            this.modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
            this.modificarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.modificarEmpleadoToolStripMenuItem.Text = "Modificar Empleado";
            this.modificarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.modificarEmpleadoToolStripMenuItem_Click);
            // 
            // buscarEmpleadoToolStripMenuItem
            // 
            this.buscarEmpleadoToolStripMenuItem.Name = "buscarEmpleadoToolStripMenuItem";
            this.buscarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.buscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado";
            this.buscarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.buscarEmpleadoToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direccion:";
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(105, 33);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(597, 22);
            this.txtArchivo.TabIndex = 2;
            this.txtArchivo.Text = "C:\\Users\\Polar\\Documents\\Matematicas discretas\\AplicacionEmpleadoArchivo\\PruebaRe" +
    "gistros.txt";
            // 
            // btnDireccion
            // 
            this.btnDireccion.Location = new System.Drawing.Point(708, 29);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(67, 37);
            this.btnDireccion.TabIndex = 3;
            this.btnDireccion.Text = "...";
            this.btnDireccion.UseVisualStyleBackColor = true;
            this.btnDireccion.Click += new System.EventHandler(this.btnDireccion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seleccionar Ruta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtArchivo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDireccion);
            this.panel1.Location = new System.Drawing.Point(31, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 155);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar Ubicacion Del Archivo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacionArchivoEmpleado.Properties.Resources.logo_universidad_de_ibague_1150x445;
            this.pictureBox1.Location = new System.Drawing.Point(31, 262);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GUIPrincipal";
            this.Text = "Empleado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mostrarGrillaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem buscarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
    }
}

