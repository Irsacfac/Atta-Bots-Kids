using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atta_Bots_Kids
{
    public partial class Main : Form
    {
        private bool cicloActivo;
        private bool detectarObstaculo;
        private List<Contenedor> instrucciones;
        private Contenedor ciclo;
        public Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTc5NDk3M0AzMjMxMmUzMTJlMzMzNUZLTGw0RG5rRDVYUGVTMHJSamlIaEM2MWpHWWxEdkJKMEtMd21LSi9ybzQ9"); // llave de acceso de Syncfusion
            InitializeComponent();
            configSerialPort();
            cicloActivo = false;
            detectarObstaculo = false;
            instrucciones = new List<Contenedor>();
            Globals.posicionCiclo = -1;
        }

        // 
        // acciones al hacer click
        //
        private void Avanzar_Click(object sender, EventArgs e)
        {
            // se revisa si se alcanzó el limite de instrcciones
            if (Globals.CantInstrucciones != Globals.limiteInstrucciones)
            {
                string value = "";
                // se llama al Form2 (Movimiento), para solicitar los datos o cancelar la acción
                using (Movimiento movimiento = new Movimiento("Movimiento", "¿Cuanto quieres avanzar?"))
                {
                    // si se confirma se agrega la instruccion a la lista
                    if (movimiento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        instrucciones.Add(new Contenedor(DisplayHistorial, instrucciones, Globals.Funciones.Avanzar, movimiento.TrackbarValue));
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
            // se revisa si se alcanzó el limite de instrcciones
            if (Globals.CantInstrucciones != Globals.limiteInstrucciones)
            {
                string value = "";
                // se llama al Form2 (Movimiento), para solicitar los datos o cancelar la acción
                using (Movimiento movimiento = new Movimiento("Movimiento", "¿Cuanto quieres retroceder?"))
                {
                    // si se confirma se agrega la instruccion a la lista
                    if (movimiento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        instrucciones.Add(new Contenedor(DisplayHistorial, instrucciones, Globals.Funciones.Retroceder, movimiento.TrackbarValue));
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
            // se revisa si se alcanzó el limite de instrcciones
            if (Globals.CantInstrucciones != Globals.limiteInstrucciones)
            {
                // se llama al Form3 (Giro), para solicitar los datos o cancelar la acción
                using (Giro giro = new Giro("¿Cuanto quieres girar?", false))
                {
                    // si se confirma se agrega la instruccion a la lista
                    if (giro.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        instrucciones.Add(new Contenedor(DisplayHistorial, instrucciones, Globals.Funciones.Izquierda, giro.TrackbarValue));
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
            // se revisa si se alcanzó el limite de instrcciones
            if (Globals.CantInstrucciones != Globals.limiteInstrucciones)
            {
                // se llama al Form3 (Giro), para solicitar los datos o cancelar la acción
                using (Giro giro = new Giro("¿Cuanto quieres girar?", true))
                {
                    // si se confirma se agrega la instruccion a la lista
                    if (giro.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        instrucciones.Add(new Contenedor(DisplayHistorial, instrucciones, Globals.Funciones.Derecha, giro.TrackbarValue));
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
            // preguntar si se desea activar/desactivar el ciclo
            if (!cicloActivo)
            {
                if (InputBoxConfirmacion("Confirmar", "¿Desea agregar un ciclo?") == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    Ciclo.BackgroundImage = Properties.Resources.Repetir_Boton_Apagado; //cambiar imagen del boton
                    cicloActivo = !cicloActivo; // activar ciclo
                    Globals.PosicionInstrucciones = 55; // cambiar ejeX de las nuevas instrucciones
                    ciclo = new Contenedor(Globals.Funciones.Ciclo, "111"); // crear instruccion
                    instrucciones.Add(ciclo); // agregar instruccion
                    Globals.posicionCiclo = instrucciones.IndexOf(ciclo); // posición del ciclo
                }
            }
            else
            {
                if (InputBoxConfirmacion("Confirmar", "¿Desea quitar el ciclo?") == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    Ciclo.BackgroundImage = Properties.Resources.Repetir_Boton; //cambiar imagen del boton
                    cicloActivo = !cicloActivo; // desactivar ciclo
                    Globals.PosicionInstrucciones = 5; // cambiar ejeX de las nuevas instrucciones
                    ajustarInstrucciones();
                    Globals.posicionCiclo = -1; // indicar que no hay ciclo
                }
            }
        }

        private void Obstaculo_Click(object sender, EventArgs e)
        {
            // preguntar si se desea activar/desactivar la detección de objetos
            if (!detectarObstaculo)
            {
                if (InputBoxConfirmacion("Confirmar", "¿Desea detectar obstáculos?") == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    Obstaculo.BackgroundImage = Properties.Resources.Obstaculo_Boton_Apagado;//cambiar imagen del boton
                    detectarObstaculo = !detectarObstaculo; // detectar obstaculos
                }
            }
            else
            {
                if (InputBoxConfirmacion("Confirmar", "¿Desea no detectar obstáculos?") == DialogResult.OK)
                {
                    Console.WriteLine("OK");
                    Obstaculo.BackgroundImage = Properties.Resources.Obstaculo_Boton;//cambiar imagen del boton
                    detectarObstaculo = !detectarObstaculo; // dejar de detactar obstaculos
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
                limpiarHistorial();
            }
        }   
        private void limpiarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputBoxConfirmacion("Confirmar", "¿Desea borrar el historial?") == DialogResult.OK)
            {
                limpiarHistorial();
            }
        }
        // 
        // funciones auxiliares
        //
        private void limpiarHistorial()
        {
            Console.WriteLine("OK");
            DisplayHistorial.Controls.Clear(); // eliminar todos los controles del panel
            DisplayHistorial.Controls.Add(Limpiar); // agregamos el boton "Limpiar"
            foreach (Contenedor instruccion in instrucciones)
            {
                instruccion.Clear(); // nos desacemos de las instrucciones para que no haya un memory leak
            }
            instrucciones.Clear(); // limpiamos la lista
            Globals.CantInstrucciones = 0; // hacemos un reset al numeo de instrucciones
            cicloActivo = false; // no tenemos un ciclo
            detectarObstaculo = false; // no detectamos obstaculos
            Obstaculo.BackgroundImage = Properties.Resources.Obstaculo_Boton; // cambiamos la imagen en caso de que sea la deseada
            Ciclo.BackgroundImage = Properties.Resources.Repetir_Boton; // cambiamos la imagen en caso de que sea la deseada
            Globals.PosicionInstrucciones = 5; // nuevo ejeX de las instrucciones en el historial
        }

        //se llama cuando se desactiva el ciclo
        private void ajustarInstrucciones()
        {
            // si el ciclo era la ultima instruccion solo se borra
            if (instrucciones.Last() == ciclo)
            {
                instrucciones.Remove(ciclo);
            }
            else
            {
                int posCiclo = instrucciones.IndexOf(ciclo); // conseguimos la posición del ciclo
                instrucciones.Remove(ciclo); // eliminamos el ciclo del historial
                for (int i = posCiclo; i < instrucciones.Count; i++)
                {
                    // ajustamos la el ejeX de las instrucciones que se agregaron despues del ciclo
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
        // 
        // dialog boxes
        //
        // Dialog box de confirmación, aparece al momento de realizar alguna acción que requiera ser confirmada o rechazada
        public static DialogResult InputBoxConfirmacion(string title, string promptText)
        {
            // elementos del dialog box
            Form form = new Form();
            Label label = new Label();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();


            form.Text = title; //titulo del dialog box
            label.Text = promptText; //texto del dialog box

            // funcionalidad de los botones del dialog box
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

            // configuración del dialog box
            label.AutoSize = true;
            form.ClientSize = new Size(361, 218);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));

            // agregar elementos al dialog box
            form.Controls.AddRange(new Control[] { label, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog(); //mostrar el dialog box

            return dialogResult;
        }
        // Dialog box para indicar que el limite de instrucciones a sido alcanzada
        public static DialogResult InputBoxLimiteAlcanzado()
        {
            // elementos del dialog box
            Form form = new Form();
            Label label = new Label();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();


            form.Text = "Alerta"; //titulo del dialog box
            label.Text = "Limite de instrucciones alcanzado"; //texto del dialog box

            // funcionalidad de los botones del dialog box
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

            // configuración del dialog box
            label.AutoSize = true;
            form.ClientSize = new Size(361, 218);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(235)))));

            // agregar elementos al dialog box
            form.Controls.AddRange(new Control[] { label, buttonOk });
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog(); //mostrar el dialog box

            return dialogResult;
        }

        private void configSerialPort()
        {
            int velocidad = 5;
            serialPort1 = new SerialPort("nombrepuerto", velocidad); //Asignacion de valores a los combo box de puerto y velocidad
            serialPort1.Open();
            serialPort1.WriteLine("0");
        }
    }
}
