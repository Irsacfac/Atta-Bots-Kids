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
        public Main()
        {
            InitializeComponent();
            //serialPort1.Open();
        }

        // El codigo aqui se activara cuando el usuario presione el boton "Avanzar"
        private void Avanzar_Click(object sender, EventArgs e)
        {
            string value = "";
            using (Movimiento movimiento = new Movimiento("Movimiento", "¿Cuanto quieres avanzar?"))
            {
                if(movimiento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    value = movimiento.TrackbarValue;
                    Console.WriteLine(value);
                }
            }
            /*if (InputBoxMovimiento("Movimiento", "¿Cuanto quieres avanzar?", ref value, this) == DialogResult.OK)
            {
                Console.WriteLine(value);
            }*/
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            string value = "";
            using (Movimiento movimiento = new Movimiento("Movimiento", "¿Cuanto quieres retroceder?"))
            {
                if (movimiento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    value = movimiento.TrackbarValue;
                    Console.WriteLine(value);
                }
            }
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {

        }

        private void Derecha_Click(object sender, EventArgs e)
        {

        }

        private void Ciclo_Click(object sender, EventArgs e)
        {
            if (InputBoxConfirmacion("Confirmar", "¿Desea agregar un ciclo?") == DialogResult.OK)
            {
                Console.WriteLine("OK");
            }
        }

        private void Obstaculo_Click(object sender, EventArgs e)
        {
            if (InputBoxConfirmacion("Confirmar", "¿Desea detectar obstaculos?") == DialogResult.OK)
            {
                Console.WriteLine("OK");
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
            if (InputBoxConfirmacion("Confirmar", "¿Desea detener el robot?") == DialogResult.OK)
            {
                Console.WriteLine("OK");
            }
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

            // posicionamiento de los elementos
            label.SetBounds(36, 36, 372, 13);
            buttonOk.SetBounds(80, 160, 160, 60);
            buttonCancel.SetBounds(270, 160, 160, 60);

            // configuración del pop-up
            label.AutoSize = true;
            form.ClientSize = new Size(500, 310);
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
    }
}
