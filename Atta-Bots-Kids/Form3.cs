using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atta_Bots_Kids
{
    public partial class Giro : Form
    {
        public string TrackbarValue { get; set; }
        public Giro(string promptText, int max, int min)
        {
            InitializeComponent();
            texto.Text = promptText; //texto del pop-up
            TrackbarValue = radialSlider1.Value.ToString();
            radialSlider1.ValueChanged += new Syncfusion.Windows.Forms.Tools.RadialSlider.ValueChangedEventHandler(radialSlider1_ValueChanged);
            radialSlider1.MaximumValue = max;
            radialSlider1.MinimumValue = min;
        }

        private void radialSlider1_Click(object sender, EventArgs e)
        {
            TrackbarValue = radialSlider1.Value.ToString();
        }

        private void radialSlider1_ValueChanged(object sender, Syncfusion.Windows.Forms.Tools.RadialSlider.ValueChangedEventArgs args)
        {
            //this.richTextBox1.SelectionFont = new System.Drawing.Font(Font.Name, (float)this.radialSlider1.Value);
            TrackbarValue = ((int)radialSlider1.Value).ToString(); 
            this.Refresh();
        }
    }
}
