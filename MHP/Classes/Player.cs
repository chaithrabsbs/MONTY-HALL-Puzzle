using MHP.Enums;
using MHP.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHP.Classes
{
    public class Player : IPlayer
    {
        private IGame Game { get; }

        private readonly Random _random;

        public Player(IGame game)
        {
            Game = game;
            _random = new Random();
        }
        public ArrayList AutoPlay(bool shouldChangeChoice)
        {
            Game.WinCount = 0;
            ArrayList arlist = new ArrayList();
            int[] winloss = new int[2];

            for (var i = 0; i < Game.GameCount; i++)
            {
                var initialChoose = _random.Next(0, 3);

                Game.UserChoosesDoor(initialChoose);
                Game.SpeakerOpensDoor();

                var chosenDoor = shouldChangeChoice
                    ? Game.UserChoosesDoor(DoorState.Initial)
                    : Game.UserChoosesDoor(DoorState.Chosen);

                if (chosenDoor.Prize == Classes.Game.Car)
                {
                    Game.WinCount++;
                }
                else
                {
                    Game.LossCount++;
                }
                
                Game.ResetGame();
                
            }
         //Adding results to list
            arlist.Add(Game.WinCount);
            arlist.Add(Game.LossCount);
            arlist.Add(Game.WinRatePercentage);
            arlist.Add(Game.LossRatePercentage);
            
            return arlist;
        }

    }
}
