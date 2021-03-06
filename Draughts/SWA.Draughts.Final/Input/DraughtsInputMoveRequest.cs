﻿namespace SWA.Draughts.Final.Input
{
    public class DraughtsInputMoveRequest : DraughtsInput, IRequestHasPositionInformation
    {
        public int ToX { get; set; }
        public int ToY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public override string PrintMyMove()
        {
            return PrintMyMove(0, 0);
        }

        public new string PrintMyMove(int deltaX, int deltaY)
        {
            return $"{X+deltaX}/{Y+deltaY} -> {ToX+deltaX}/{ToY+deltaY}";
        }
    }
}
