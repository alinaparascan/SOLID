using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor
{
    public class DogDoor
    {
        public Boolean Status { get; set; }

        public void Open()
        {
            Status = true;
        }

        public void Close ()
        {
            Status = false;
        }

    }
}
