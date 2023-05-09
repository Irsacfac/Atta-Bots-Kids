using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using static Globals;

namespace Atta_Bots_Kids
{
    internal class Contenedor
    {
        private PictureBox imagenInstruccion;
        private Button boton;
        private Panel historial;
        private string codigo;
        private string valor;
        private List<Contenedor> instrucciones;

        public Contenedor(Funciones funcion, string valor)
        {
            this.valor = valor;
            codigo = codigos[(int)funcion];
            boton = null;
            imagenInstruccion = null;
        }
        public Contenedor(Panel historial, List<Contenedor> instrucciones, Funciones funcion, string valor, bool ciclo)
        {
            this.instrucciones = instrucciones;
            this.historial = historial; 
            this.valor = valor;
            int ajuste = 0;
            if (!ciclo)
            {
                ajuste = 50;
            }
            InitializeComponent(ajuste);
            //this.imagenInstruccion.BackgroundImage = global::Atta_Bots_Kids.Properties.Resources.Izquierda_Boton;
            codigo = codigos[(int)funcion];
            switch (funcion)
            {
                case Funciones.Avanzar:
                    imagenInstruccion.BackgroundImage = Properties.Resources.Avanzar_Boton;
                    break;
                case Funciones.Retroceder:
                    imagenInstruccion.BackgroundImage = Properties.Resources.Atras_Boton;
                    break;
                case Funciones.Izquierda:
                    imagenInstruccion.BackgroundImage = Properties.Resources.Izquierda_Boton;
                    break;
                case Funciones.Derecha:
                    imagenInstruccion.BackgroundImage = Properties.Resources.Derecha_Boton;
                    break;
                default: //play
                    break;
            }
        }

        private void InitializeComponent(int ajuste)
        {
            int ejeX = PosicionInstrucciones;
            int ejeY = tamanioInstrucciones * CantInstrucciones + espacioEntreInstrucciones * CantInstrucciones;
            boton = new Button();
            imagenInstruccion = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenInstruccion)).BeginInit();

            historial.Controls.Add(this.imagenInstruccion);
            historial.Controls.Add(this.boton);
            // 
            // imagenInstruccion
            // 
            this.imagenInstruccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            //this.imagenInstruccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagenInstruccion.Location = new System.Drawing.Point(ejeX, ejeY);
            this.imagenInstruccion.Name = "imagenInstruccion";
            this.imagenInstruccion.Size = new System.Drawing.Size(tamanioInstrucciones, tamanioInstrucciones);
            this.imagenInstruccion.TabIndex = 1;
            this.imagenInstruccion.TabStop = false;
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            //this.boton.Dock = System.Windows.Forms.DockStyle.Right;
            this.boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Bold);
            this.boton.Location = new System.Drawing.Point(ejeX+tamanioInstrucciones, ejeY);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(tamanioInstrucciones, tamanioInstrucciones);
            this.boton.TabIndex = 0;
            this.boton.Text = "X";
            this.boton.UseVisualStyleBackColor = false;
            this.boton.Click += new System.EventHandler(this.Boton_Click);
        }
        //elimina la instruccion deseada, no se pregunta por confirmación
        private void Boton_Click(object sender, EventArgs e)
        {
            historial.Controls.Remove(this.boton);
            historial.Controls.Remove(this.imagenInstruccion);
            boton.Dispose();
            imagenInstruccion.Dispose();
            if (instrucciones.Last() == this)
            {
                instrucciones.Remove(this);
            }
            else
            {
                int pos = instrucciones.IndexOf(this);
                int ejeY;
                instrucciones.Remove(this);
                for (int i = pos; i < instrucciones.Count; i++)
                {
                    ejeY = tamanioInstrucciones * i + espacioEntreInstrucciones * i;
                    instrucciones[i].actualizarPosicion(PosicionInstrucciones, ejeY);
                }
                Console.WriteLine("borrado");
            }
            eliminarInstruccion();
        }
        public void Clear()
        {
            //historial.Controls.Remove(this.boton);
            //historial.Controls.Remove(this.imagenInstruccion);
            if (boton != null)
            {
                boton.Dispose();
                imagenInstruccion.Dispose();
            }
        }
        public void actualizarPosicion(int ejeX, int ejeY)
        {
            this.imagenInstruccion.Location = new System.Drawing.Point(ejeX, ejeY);
            this.boton.Location = new System.Drawing.Point(ejeX + tamanioInstrucciones, ejeY);
        }
        public override string ToString()
        {
            return codigo + "-" + valor;
        }
    }
}
