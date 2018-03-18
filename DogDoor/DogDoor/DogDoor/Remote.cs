using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogDoor
{
    public class Remote
    {
        private DogDoor door;
        System.Timers.Timer tSec = new System.Timers.Timer(5000);

        public Remote(DogDoor door)
        {
            this.door = door;
            tSec.Elapsed += new System.Timers.ElapsedEventHandler(OnTimerEvent);
        }

        public Boolean PressButton()
        {
            if (door.Status)
            {
                door.Close();
            }
            else
            {
                door.Open();
            }
           
            tSec.Enabled = true;
            return door.Status;
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            tSec.Enabled = false;
            door.Close();            
            MessageBox.Show("The door automatically closes...");            
        }
    }
}
