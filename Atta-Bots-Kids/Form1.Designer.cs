namespace Atta_Bots_Kids
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Herramientas = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Historial = new System.Windows.Forms.Panel();
            this.Botones = new System.Windows.Forms.Panel();
            this.label_Acciones = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Obstaculo = new System.Windows.Forms.Button();
            this.Ciclo = new System.Windows.Forms.Button();
            this.Derecha = new System.Windows.Forms.Button();
            this.Izquierda = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.Avanzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayHistorial = new System.Windows.Forms.Panel();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Herramientas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Historial.SuspendLayout();
            this.Botones.SuspendLayout();
            this.DisplayHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // Herramientas
            // 
            this.Herramientas.AutoSize = true;
            this.Herramientas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Herramientas.Controls.Add(this.menuStrip1);
            this.Herramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Herramientas.Location = new System.Drawing.Point(0, 0);
            this.Herramientas.Name = "Herramientas";
            this.Herramientas.Size = new System.Drawing.Size(800, 30);
            this.Herramientas.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarHistorialToolStripMenuItem,
            this.generarDocumentoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // limpiarHistorialToolStripMenuItem
            // 
            this.limpiarHistorialToolStripMenuItem.Name = "limpiarHistorialToolStripMenuItem";
            this.limpiarHistorialToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.limpiarHistorialToolStripMenuItem.Text = "Limpiar Historial";
            // 
            // generarDocumentoToolStripMenuItem
            // 
            this.generarDocumentoToolStripMenuItem.Name = "generarDocumentoToolStripMenuItem";
            this.generarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.generarDocumentoToolStripMenuItem.Text = "Generar Documento";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Historial
            // 
            this.Historial.Controls.Add(this.DisplayHistorial);
            this.Historial.Controls.Add(this.label1);
            this.Historial.Dock = System.Windows.Forms.DockStyle.Right;
            this.Historial.Location = new System.Drawing.Point(383, 30);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(417, 663);
            this.Historial.TabIndex = 1;
            // 
            // Botones
            // 
            this.Botones.Controls.Add(this.label_Acciones);
            this.Botones.Controls.Add(this.Stop);
            this.Botones.Controls.Add(this.Play);
            this.Botones.Controls.Add(this.Obstaculo);
            this.Botones.Controls.Add(this.Ciclo);
            this.Botones.Controls.Add(this.Derecha);
            this.Botones.Controls.Add(this.Izquierda);
            this.Botones.Controls.Add(this.Atras);
            this.Botones.Controls.Add(this.Avanzar);
            this.Botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Botones.Location = new System.Drawing.Point(0, 30);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(383, 663);
            this.Botones.TabIndex = 2;
            // 
            // label_Acciones
            // 
            this.label_Acciones.AutoSize = true;
            this.label_Acciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Acciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Acciones.Location = new System.Drawing.Point(0, 0);
            this.label_Acciones.Name = "label_Acciones";
            this.label_Acciones.Size = new System.Drawing.Size(111, 29);
            this.label_Acciones.TabIndex = 0;
            this.label_Acciones.Text = "Acciones";
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.Location = new System.Drawing.Point(172, 426);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(128, 128);
            this.Stop.TabIndex = 7;
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(23, 426);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(128, 128);
            this.Play.TabIndex = 6;
            this.Play.UseVisualStyleBackColor = true;
            // 
            // Obstaculo
            // 
            this.Obstaculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Obstaculo.Location = new System.Drawing.Point(172, 293);
            this.Obstaculo.Name = "Obstaculo";
            this.Obstaculo.Size = new System.Drawing.Size(128, 130);
            this.Obstaculo.TabIndex = 5;
            this.Obstaculo.UseVisualStyleBackColor = true;
            // 
            // Ciclo
            // 
            this.Ciclo.AutoSize = true;
            this.Ciclo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ciclo.Image = ((System.Drawing.Image)(resources.GetObject("Ciclo.Image")));
            this.Ciclo.Location = new System.Drawing.Point(23, 293);
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.Size = new System.Drawing.Size(128, 128);
            this.Ciclo.TabIndex = 4;
            this.Ciclo.UseVisualStyleBackColor = true;
            // 
            // Derecha
            // 
            this.Derecha.AutoSize = true;
            this.Derecha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Derecha.Image = ((System.Drawing.Image)(resources.GetObject("Derecha.Image")));
            this.Derecha.Location = new System.Drawing.Point(172, 161);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(128, 129);
            this.Derecha.TabIndex = 3;
            this.Derecha.UseVisualStyleBackColor = true;
            // 
            // Izquierda
            // 
            this.Izquierda.AutoSize = true;
            this.Izquierda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Izquierda.Image = ((System.Drawing.Image)(resources.GetObject("Izquierda.Image")));
            this.Izquierda.Location = new System.Drawing.Point(23, 161);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(128, 128);
            this.Izquierda.TabIndex = 2;
            this.Izquierda.UseVisualStyleBackColor = true;
            // 
            // Atras
            // 
            this.Atras.AutoSize = true;
            this.Atras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.Location = new System.Drawing.Point(172, 29);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(128, 130);
            this.Atras.TabIndex = 1;
            this.Atras.UseVisualStyleBackColor = true;
            // 
            // Avanzar
            // 
            this.Avanzar.AutoSize = true;
            this.Avanzar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Avanzar.Image = ((System.Drawing.Image)(resources.GetObject("Avanzar.Image")));
            this.Avanzar.Location = new System.Drawing.Point(23, 29);
            this.Avanzar.Name = "Avanzar";
            this.Avanzar.Size = new System.Drawing.Size(128, 130);
            this.Avanzar.TabIndex = 0;
            this.Avanzar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
            // 
            // DisplayHistorial
            // 
            this.DisplayHistorial.BackColor = System.Drawing.Color.White;
            this.DisplayHistorial.Controls.Add(this.Limpiar);
            this.DisplayHistorial.Location = new System.Drawing.Point(30, 29);
            this.DisplayHistorial.Name = "DisplayHistorial";
            this.DisplayHistorial.Size = new System.Drawing.Size(361, 584);
            this.DisplayHistorial.TabIndex = 1;
            // 
            // Limpiar
            // 
            this.Limpiar.AutoSize = true;
            this.Limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Limpiar.Image")));
            this.Limpiar.Location = new System.Drawing.Point(271, 0);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(90, 98);
            this.Limpiar.TabIndex = 0;
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.Botones);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.Herramientas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Atta-Bots Kids";
            this.Herramientas.ResumeLayout(false);
            this.Herramientas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Historial.ResumeLayout(false);
            this.Historial.PerformLayout();
            this.Botones.ResumeLayout(false);
            this.Botones.PerformLayout();
            this.DisplayHistorial.ResumeLayout(false);
            this.DisplayHistorial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel Herramientas;
        private System.Windows.Forms.Panel Historial;
        private System.Windows.Forms.Panel Botones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Obstaculo;
        private System.Windows.Forms.Button Ciclo;
        private System.Windows.Forms.Button Derecha;
        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Avanzar;
        private System.Windows.Forms.Label label_Acciones;
        private System.Windows.Forms.Panel DisplayHistorial;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label1;
    }
}

