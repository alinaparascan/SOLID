using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogDoor
{
    public partial class fDoggyBusiness : Form
    {
        static DogDoor door = new DogDoor();
        Remote rem = new Remote(door);

        public fDoggyBusiness()
        {
            InitializeComponent();
        }

        private string RemoteAction()
        {
            if (rem.PressButton())
            {
                return "The door is open!";
            }
            return "The door is closed!";
        }

        private void bDoStuff_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "Fido barks to go outside!";
            rtbResult.Text += "\n" + RemoteAction();
            rtbResult.Text += "\nFido is outside!";
            rtbResult.Refresh();
            System.Threading.Thread.Sleep(5000);
            rtbResult.Refresh();
            rtbResult.Text += "\nWaited 5 seconds for Fido to do his business...";
            rtbResult.Text += "\n" + RemoteAction();
            rtbResult.Text += "\nFido has finished!";
            rtbResult.Text += "\n" + RemoteAction();
            rtbResult.Text += "\nFido is in the house!";
            rtbResult.Text += "\n" + RemoteAction();
        }
    }
}
