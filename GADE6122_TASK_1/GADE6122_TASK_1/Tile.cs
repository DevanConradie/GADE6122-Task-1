using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_1
{
    abstract class Tile
    {
        protected int members;
        public int X;
        public int Y;
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
