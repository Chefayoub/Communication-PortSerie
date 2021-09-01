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

namespace AA_PortSerie
{
    public partial class Accueil : Form
    {
        SerialPort port;
        public string dataOut;


        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            string[] serialPorts = SerialPort.GetPortNames();
            cbCom.Items.AddRange(serialPorts);

        }

        private void PortWrite(string message)
        {
            if (port != null && port.IsOpen)
            {
                port.Write(message);
            }
        }

        private void allumer()
        {
            if (port == null)
            {
                //Change the portname according to your computer
                port = new SerialPort(cbCom.SelectedItem.ToString(), 9600);
                port.Open();
            }
        }


        #region COMMUNICATION -- Temperature et Humiditer------------------
        private void btnLireDonnees_Click(object sender, EventArgs e)
        {
            allumer();
            //timer1.Enabled = true;
            string nom = port.ReadLine();
            rtbAffichageText.Text = nom;
        }
        #endregion


        #region Controle des leds
        private void bLedVerteON_Click(object sender, EventArgs e)
        {
            allumer();
            PortWrite("1");
        }

        private void bLedVerteOFF_Click(object sender, EventArgs e)
        {
            allumer();
            PortWrite("2");
        }

        private void bLedJauneON_Click(object sender, EventArgs e)
        {
            allumer();
            PortWrite("3");
        }

        private void bLedJauneOFF_Click(object sender, EventArgs e)
        {
            allumer();
            PortWrite("4");
        }

        private void bLedRougeON_Click(object sender, EventArgs e)
        {
            allumer();
            PortWrite("5");
        }

        private void bLedRougeOFF_Click(object sender, EventArgs e)
        {
            allumer();
            PortWrite("6");
        }

        #endregion


        #region Envoyer des donnée
        private void bSend_Click(object sender, EventArgs e)
        {
            allumer();
            string mdp= tbOut.Text;
            PortWrite(mdp);
        }


        #endregion


        #region Controle du buzzer
        private void bBuzzerON_Click(object sender, EventArgs e)
        {
            allumer();
            PortWrite("7");
        }

        private void bBuzzerOFF_Click(object sender, EventArgs e)
        {
            allumer();
            PortWrite("8");
        }
        #endregion
    }
}
