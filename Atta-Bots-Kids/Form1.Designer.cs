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
            this.DisplayHistorial = new System.Windows.Forms.Panel();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Herramientas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Historial.SuspendLayout();
            this.DisplayHistorial.SuspendLayout();
            this.Botones.SuspendLayout();
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
            this.Herramientas.Size = new System.Drawing.Size(800, 28);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarHistorialToolStripMenuItem,
            this.generarDocumentoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
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
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
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
            this.Historial.Location = new System.Drawing.Point(383, 28);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(417, 665);
            this.Historial.TabIndex = 1;
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
            this.Limpiar.FlatAppearance.BorderSize = 0;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Limpiar.Image")));
            this.Limpiar.Location = new System.Drawing.Point(285, 1);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 82);
            this.Limpiar.TabIndex = 0;
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
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
            this.Botones.Location = new System.Drawing.Point(0, 28);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(383, 665);
            this.Botones.TabIndex = 2;
            // 
            // label_Acciones
            // 
            this.label_Acciones.AutoSize = true;
            this.label_Acciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Acciones.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Acciones.Location = new System.Drawing.Point(0, 0);
            this.label_Acciones.Name = "label_Acciones";
            this.label_Acciones.Size = new System.Drawing.Size(110, 29);
            this.label_Acciones.TabIndex = 0;
            this.label_Acciones.Text = "Acciones";
            // 
            // Stop
            // 
            this.Stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.Location = new System.Drawing.Point(199, 395);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(108, 108);
            this.Stop.TabIndex = 7;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(50, 395);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(108, 108);
            this.Play.TabIndex = 6;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Obstaculo
            // 
            this.Obstaculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Obstaculo.FlatAppearance.BorderSize = 0;
            this.Obstaculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Obstaculo.Image = ((System.Drawing.Image)(resources.GetObject("Obstaculo.Image")));
            this.Obstaculo.Location = new System.Drawing.Point(199, 277);
            this.Obstaculo.Name = "Obstaculo";
            this.Obstaculo.Size = new System.Drawing.Size(108, 108);
            this.Obstaculo.TabIndex = 5;
            this.Obstaculo.UseVisualStyleBackColor = true;
            this.Obstaculo.Click += new System.EventHandler(this.Obstaculo_Click);
            // 
            // Ciclo
            // 
            this.Ciclo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ciclo.FlatAppearance.BorderSize = 0;
            this.Ciclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ciclo.Image = ((System.Drawing.Image)(resources.GetObject("Ciclo.Image")));
            this.Ciclo.Location = new System.Drawing.Point(50, 277);
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.Size = new System.Drawing.Size(108, 108);
            this.Ciclo.TabIndex = 4;
            this.Ciclo.UseVisualStyleBackColor = true;
            this.Ciclo.Click += new System.EventHandler(this.Ciclo_Click);
            // 
            // Derecha
            // 
            this.Derecha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Derecha.FlatAppearance.BorderSize = 0;
            this.Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Derecha.Image = ((System.Drawing.Image)(resources.GetObject("Derecha.Image")));
            this.Derecha.Location = new System.Drawing.Point(199, 154);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(108, 109);
            this.Derecha.TabIndex = 3;
            this.Derecha.UseVisualStyleBackColor = true;
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // Izquierda
            // 
            this.Izquierda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Izquierda.FlatAppearance.BorderSize = 0;
            this.Izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izquierda.Image = ((System.Drawing.Image)(resources.GetObject("Izquierda.Image")));
            this.Izquierda.Location = new System.Drawing.Point(50, 154);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(108, 108);
            this.Izquierda.TabIndex = 2;
            this.Izquierda.UseVisualStyleBackColor = true;
            this.Izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // Atras
            // 
            this.Atras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Atras.FlatAppearance.BorderSize = 0;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.Location = new System.Drawing.Point(199, 33);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(106, 108);
            this.Atras.TabIndex = 1;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Avanzar
            // 
            this.Avanzar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Avanzar.FlatAppearance.BorderSize = 0;
            this.Avanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Avanzar.Image = ((System.Drawing.Image)(resources.GetObject("Avanzar.Image")));
            this.Avanzar.Location = new System.Drawing.Point(50, 33);
            this.Avanzar.Name = "Avanzar";
            this.Avanzar.Size = new System.Drawing.Size(108, 109);
            this.Avanzar.TabIndex = 0;
            this.Avanzar.UseVisualStyleBackColor = true;
            this.Avanzar.Click += new System.EventHandler(this.Avanzar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));
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
            this.DisplayHistorial.ResumeLayout(false);
            this.DisplayHistorial.PerformLayout();
            this.Botones.ResumeLayout(false);
            this.Botones.PerformLayout();
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
        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Avanzar;
        private System.Windows.Forms.Label label_Acciones;
        private System.Windows.Forms.Panel DisplayHistorial;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Derecha;
    }
}

