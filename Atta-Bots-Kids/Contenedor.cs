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
            ((System.ComponentModel.ISupportInitialize)(imagenInstruccion)).BeginInit();

            historial.Controls.Add(imagenInstruccion);
            historial.Controls.Add(boton);
            // 
            // imagenInstruccion
            // 
            imagenInstruccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            imagenInstruccion.Location = new System.Drawing.Point(ejeX, ejeY+historial.AutoScrollPosition.Y);
            imagenInstruccion.Name = "imagenInstruccion";
            imagenInstruccion.Size = new System.Drawing.Size(tamanioInstrucciones, tamanioInstrucciones);
            imagenInstruccion.TabIndex = 1;
            imagenInstruccion.TabStop = false;
            // 
            // boton
            // 
            boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            boton.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Bold);
            boton.Location = new System.Drawing.Point(ejeX+tamanioInstrucciones, ejeY + historial.AutoScrollPosition.Y);
            boton.Name = "boton";
            boton.Size = new System.Drawing.Size(tamanioInstrucciones, tamanioInstrucciones);
            boton.TabIndex = 0;
            boton.Text = "X";
            boton.UseVisualStyleBackColor = false;
            boton.Click += new System.EventHandler(Boton_Click);
        }
        //elimina la instruccion deseada, no se pregunta por confirmación
        private void Boton_Click(object sender, EventArgs e)
        {
            historial.Controls.Remove(boton);
            historial.Controls.Remove(imagenInstruccion);
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
                    if(i != posicionCiclo)
                    {
                        ejeY = tamanioInstrucciones * i + espacioEntreInstrucciones * i;
                        instrucciones[i].actualizarPosicion(PosicionInstrucciones, ejeY);
                    };
                    /*if(i <= posicionCiclo && posicionCiclo != -1)
                    {
                        ejeY = tamanioInstrucciones * i + espacioEntreInstrucciones * i;
                        instrucciones[i].actualizarPosicion(5, ejeY);
                    }else if(i >= posicionCiclo && i <= posicionCiclo)
                    {
                        ejeY = tamanioInstrucciones * i + espacioEntreInstrucciones * i;
                        instrucciones[i].actualizarPosicion(55, ejeY);
                    }*/
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
            imagenInstruccion.Location = new System.Drawing.Point(ejeX, ejeY + historial.AutoScrollPosition.Y);
            boton.Location = new System.Drawing.Point(ejeX + tamanioInstrucciones, ejeY + historial.AutoScrollPosition.Y);
            
        }
        public void ajustarEjeX(int ajuste)
        {
            imagenInstruccion.Left += ajuste;
            boton.Left += ajuste;
        }
        public override string ToString()
        {
            return codigo + "-" + valor;
        }
    }
}
