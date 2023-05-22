using MHP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHP.Interfaces
{
    public interface IGame
    {
        int GameCount { get; }

        int WinCount { get; set; }
        int LossCount { get; set; }
        double WinRate { get; }
        double LossRate { get; }

        string WinRatePercentage { get; }

        string LossRatePercentage { get; }


        IDoor UserChoosesDoor(int doorIndex);

        IDoor UserChoosesDoor(DoorState doorState);

        //int IndexOfDoor(IDoor door);

        IDoor SpeakerOpensDoor();

        void ResetGame();

    }
}
