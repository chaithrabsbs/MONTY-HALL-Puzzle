using MHP.Enums;
using MHP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHP.Classes
{
    public class Door : IDoor
    {
        public DoorState DoorState { get; set; }
        public string Prize { get; set; } = "";
    }
}
