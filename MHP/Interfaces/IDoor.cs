using MHP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHP.Interfaces
{
    public interface IDoor
    {
        DoorState DoorState { get; set; }
        string Prize { get; set; }
    }
}
