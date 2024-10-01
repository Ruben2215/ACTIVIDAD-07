using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Practica6
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; } //ArduinoPort es personalizable
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM5";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += CerrandoForm1_Click;
            this.bnApagar.Click += bnApagar_Click;
            this.bnEncender.Click += bnEncender_Click;

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bnEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void bnApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");

        }

        private void CerrandoForm1_Click(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
    }
}
