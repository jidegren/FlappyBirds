using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBird.Web.Models
{
    public class PipeModel
    {
        public int DistanceFromLeft { get; private set; } = 500;
        public int DistanceFromBottom { get; private set; } = new Random().Next(0, 60);
        public int Gap { get; private set; } = 130;
        public int Speed { get; private set; } = 2;
        public int GapBottom => DistanceFromBottom + 300;
        public int GapTop => GapBottom + Gap;
        public void Move()
        {
            DistanceFromLeft -= Speed;
        }
        public bool IsOffScreen()
        {
            return DistanceFromLeft <= -60;
        }

        public bool IsCentered()
        {
            bool hasEnteredCenter = DistanceFromLeft <= (500 / 2) + (60 / 2);
            bool hasExitedCenter = DistanceFromLeft <= (500 / 2) - (60 / 2) - 60;

            return hasEnteredCenter && !hasExitedCenter;
        }
    }
}
