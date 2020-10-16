using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MediaPlayer
{
    public partial class MediaForm : Form
    {
        RadioStream radioStream = new RadioStream();

        string stringUrlRadioAntena = string.Empty;
        string stringUrlRadioStarFm = string.Empty;
        string stringUrlRadioRixFm = string.Empty;

        public MediaForm()
        {
            InitializeComponent();

            foreach (var radioUrl in radioStream.radiosList())
            {
                if (radioUrl.Id == 1)
                    stringUrlRadioStarFm = radioUrl.Url;

                if (radioUrl.Id == 2)
                    stringUrlRadioRixFm = radioUrl.Url;

                if (radioUrl.Id == 3)
                    stringUrlRadioAntena = radioUrl.Url;
            }
        }


        private void buttonStarFM_Click(object sender, EventArgs e)
        {

            Player.URL = stringUrlRadioStarFm;

            Player.Ctlcontrols.play();

        }


        private void Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }






        private void buttonRixFm_Click(object sender, EventArgs e)
        {
            Player.URL = stringUrlRadioRixFm;

            Player.Ctlcontrols.play();

        }

        private void buttonAntenaRadio_Click(object sender, EventArgs e)
        {
            Player.URL = stringUrlRadioAntena;
            //ayer.URL = "http://www.antenabor.com:8018/;";

            Player.Ctlcontrols.play();
        }
    }
}
