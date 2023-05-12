using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atta_Bots_Kids
{
    public partial class Main : Form
    {
        //private Label trackbarValue;
        private bool cicloActivo;
        private bool detectarObstaculo;
        private List<Contenedor> instrucciones;
        private Contenedor ciclo;
        public Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTc5NDk3M0AzMjMxMmUzMTJlMzMzNUZLTGw0RG5rRDVYUGVTMHJSamlIaEM2MWpHWWxEdkJKMEtMd21LSi9ybzQ9");
            InitializeComponent();
            //serialPort1.Open();
            cicloActivo = true;
            detectarObstaculo = true;
            instrucciones = new List<Contenedor>();
            Globals.posicionCiclo = -1;
            //contenedores.Add(new Contenedor(DisplayHistorial,5,0, Globals.Funciones.Avanzar));
            //contenedores.Add(new Contenedor(DisplayHistorial, 5, Globals.tamanioInstrucciones + Globals.espacioEntreInstrucciones, Globals.Funciones.Izquierda));
        }

        // El codigo aqui se activara cuando el usuario presione el boton "Avanzar"
        private void Avanzar_Click(object sender, EventArgs e)
        {
            if (Globals.CantInstrucciones != Globals.limiteInstrucciones)
            {
                string value = "";
                using (Movimiento movimiento = new Movimiento("Movimiento", "¿Cuanto quieres avanzar?"))
                {
                    if (movimiento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        instrucciones.Add(new Contenedor(DisplayHistorial, instrucciones, Globals.Funciones.Avanzar, movimiento.TrackbarValue, cicloActivo));
                        value = movimiento.TrackbarValue;
                        Console.WriteLine(value);
                        Globals.agregarInstruccion();
                    }
                }
            }
            else
            {
                if (InputBoxLimiteAlcanzado() == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            if (Globals.CantInstrucciones != Globals.limiteInstrucciones)
            {
                string value = "";
                using (Movimiento movimiento = new Movimiento("Movimiento", "¿Cuanto quieres retroceder?"))
                {
                    if (movimiento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        instrucciones.Add(new Contenedor(DisplayHistorial, instrucciones, Globals.Funciones.Retroceder, movimiento.TrackbarValue, cicloActivo));
                        value = movimiento.TrackbarValue;
                        Console.WriteLine(value);
                        Globals.agregarInstruccion();
                    }
                }
            }
            else
            {
                if (InputBoxLimiteAlcanzado() == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            if (Globals.CantInstrucciones != Globals.limiteInstrucciones)
            {
                using (Giro giro = new Giro("¿Cuanto quieres girar?", false))
                {
                    if (giro.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        instrucciones.Add(new Contenedor(DisplayHistorial, instrucciones, Globals.Funciones.Izquierda, giro.TrackbarValue, cicloActivo));
                        Console.WriteLine(giro.TrackbarValue);
                        Globals.agregarInstruccion();
                    }
                }
            }
            else
            {
                if (InputBoxLimiteAlcanzado() == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            if (Globals.CantInstrucciones != Globals.limiteInstrucciones)
            {
                using (Giro giro = new Giro("¿Cuanto quieres girar?", true))
                {
                    if (giro.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        instrucciones.Add(new Contenedor(DisplayHistorial, instrucciones, Globals.Funciones.Derecha, giro.TrackbarValue, cicloActivo));
                        //value = movimiento.TrackbarValue;
                        Globals.agregarInstruccion();
                        Console.WriteLine(giro.TrackbarValue);
                    }
                }
            }
            else
            {
                if (InputBoxLimiteAlcanzado() == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void Ciclo_Click(object sender, EventArgs e)
        {
            if (cicloActivo)
            {
                if (InputBoxConfirmacion("Confirmar", "¿Desea agregar un ciclo?") == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    this.Ciclo.BackgroundImage = global::Atta_Bots_Kids.Properties.Resources.Repetir_Boton_Apagado;
                    cicloActivo = !cicloActivo;
                    Globals.PosicionInstrucciones = 55;
                    ciclo = new Contenedor(Globals.Funciones.Ciclo, "111");
                    instrucciones.Add(ciclo);
                    Globals.posicionCiclo = instrucciones.IndexOf(ciclo);
                }
            }
            else
            {
                if (InputBoxConfirmacion("Confirmar", "¿Desea quitar el ciclo?") == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    this.Ciclo.BackgroundImage = global::Atta_Bots_Kids.Properties.Resources.Repetir_Boton;
                    cicloActivo = !cicloActivo;
                    Globals.PosicionInstrucciones = 5;
                    ajustarInstrucciones();
                }
            }
        }

        private void Obstaculo_Click(object sender, EventArgs e)
        {
            if (detectarObstaculo)
            {
                if (InputBoxConfirmacion("Confirmar", "¿Desea detectar obstáculos?") == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    this.Obstaculo.BackgroundImage = global::Atta_Bots_Kids.Properties.Resources.Obstaculo_Boton_Apagado;
                    detectarObstaculo = !detectarObstaculo;
                }
            }
            else
            {
                if (InputBoxConfirmacion("Confirmar", "¿Desea no detectar obstáculos?") == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    this.Obstaculo.BackgroundImage = global::Atta_Bots_Kids.Properties.Resources.Obstaculo_Boton;
                    detectarObstaculo = !detectarObstaculo;
                }
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (InputBoxConfirmacion("Confirmar", "¿Desea cargar el código?") == DialogResult.OK)
            {
                Console.WriteLine("OK");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (InputBoxConfirmacion("Confirmar", "¿Desea detener el robot?") == DialogResult.OK)
            {
                Console.WriteLine("OK");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            if (InputBoxConfirmacion("Confirmar", "¿Desea borrar el historial?") == DialogResult.OK)
            {
                Console.WriteLine("OK");
                DisplayHistorial.Controls.Clear();
                DisplayHistorial.Controls.Add(Limpiar);
                foreach (Contenedor instruccion in instrucciones)
                {
                    instruccion.Clear();
                }
                instrucciones.Clear();
                Globals.CantInstrucciones = 0;
                cicloActivo = true;
                detectarObstaculo = true;
                Obstaculo.BackgroundImage = Properties.Resources.Obstaculo_Boton;
                Ciclo.BackgroundImage = Properties.Resources.Repetir_Boton;
                Globals.PosicionInstrucciones = 5;
            }
        }
        //se llama cuando se desactiva el ciclo
        private void ajustarInstrucciones()
        {
            if (instrucciones.Last() == ciclo)
            {
                instrucciones.Remove(ciclo);
            }
            else
            {
                int posCiclo = instrucciones.IndexOf(ciclo);
                instrucciones.Remove(ciclo);
                //int ejeY;
                for (int i = posCiclo; i < instrucciones.Count; i++)
                {
                    instrucciones[i].ajustarEjeX(-50);
                    //instrucciones[i].actualizarPosicion(Globals.PosicionInstrucciones, ejeY);
                }
            }
            /*instrucciones.RemoveAt(Globals.posicionCiclo);
            int ejeY;
            for (int i = Globals.posicionCiclo; i < instrucciones.Count; i++)
            {
                ejeY = Globals.tamanioInstrucciones * i + Globals.espacioEntreInstrucciones * i;
                instrucciones[i].actualizarPosicion(Globals.PosicionInstrucciones, ejeY);
            }
            Globals.posicionCiclo = -1;*/
            /*if(instrucciones.Last() == ciclo)
            {
                instrucciones.Remove(ciclo);
            }
            else
            {
                int posCiclo = instrucciones.IndexOf(ciclo);
                instrucciones.Remove(ciclo);
                ciclo = null;
                int ejeY;
                for (int i = posCiclo; i < instrucciones.Count; i++)
                {
                    ejeY = Globals.tamanioInstrucciones * i + Globals.espacioEntreInstrucciones * i;
                    instrucciones[i].actualizarPosicion(Globals.PosicionInstrucciones, ejeY);
                }
            }*/
        }
        // Pop-up de confirmación
        public static DialogResult InputBoxConfirmacion(string title, string promptText)
        {
            // elementos del pop-up
            Form form = new Form();
            Label label = new Label();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();


            form.Text = title; //titulo del pop-up
            label.Text = promptText; //texto del pop-up

            // funcionalidad de los botones del pop-up
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            // posicionamiento y diseño de los elementos
            label.SetBounds(36, 36, 372, 13);
            label.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F);

            buttonOk.SetBounds(40, 100, 130, 50);
            buttonOk.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F);
            buttonOk.Name = "BotonOk";
            buttonOk.TabIndex = 2;
            buttonOk.UseVisualStyleBackColor = true;

            buttonCancel.SetBounds(190, 100, 130, 50);
            buttonCancel.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F);
            buttonCancel.Name = "BotonCancelar";
            buttonCancel.TabIndex = 2;
            buttonCancel.UseVisualStyleBackColor = true;

            // configuración del pop-up
            label.AutoSize = true;
            form.ClientSize = new Size(361, 218);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));

            // agregar elementos al pop-up
            form.Controls.AddRange(new Control[] { label, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog(); //mostrar el pop-up

            return dialogResult;
        }

        public static DialogResult InputBoxLimiteAlcanzado()
        {
            // elementos del pop-up
            Form form = new Form();
            Label label = new Label();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();


            form.Text = "Alerta"; //titulo del pop-up
            label.Text = "Limite de instrucciones alcanzado"; //texto del pop-up

            // funcionalidad de los botones del pop-up
            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            // posicionamiento y diseño de los elementos
            label.SetBounds(36, 36, 372, 13);
            label.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F);

            buttonOk.SetBounds(40, 100, 130, 50);
            buttonOk.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F);
            buttonOk.Name = "BotonOk";
            buttonOk.TabIndex = 2;
            buttonOk.UseVisualStyleBackColor = true;

            // configuración del pop-up
            label.AutoSize = true;
            form.ClientSize = new Size(361, 218);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));

            // agregar elementos al pop-up
            form.Controls.AddRange(new Control[] { label, buttonOk});
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog(); //mostrar el pop-up

            return dialogResult;
        }
    }
}
