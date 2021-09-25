using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_1
{
    abstract class Tile
    {
        protected int _X;

        public int X
        {
            get => _X;
            set => _X = value;
        }

        protected int _Y;
        public int Y
        {
            get => _Y;
            set => _Y = value;
        }
        public enum TileType { Hero, Enemy, Gold, Weapon}

        
    }
    class Obstacle : Tile
    {
        

    }

    class EmptyTile : Tile
    {

    }

    abstract class Character : Tile
    {
        protected int _HP;
        public int HP
        {
            get => _HP;
            set => _HP = value;
        }

        protected int _MAXHP;
        public int MAXHP
        {
            get => _MAXHP;
            set => _MAXHP = value;
        }

        protected int _DAMAGE;
        public int DAMAGE
        {
            get => _DAMAGE;
            set => _DAMAGE = value;
        }

        int[] tiles;
        public enum Movement { NoMovement, Up, Down, Left, Right}
    }

}
