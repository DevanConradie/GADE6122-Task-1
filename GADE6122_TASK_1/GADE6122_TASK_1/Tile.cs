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
        char SYMBOL;
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

        public Character(int X_CO, int Y_CO, char Symbol)
        {
            X = X_CO;
            Y = Y_CO;
            SYMBOL = Symbol;
        }

        public virtual void Attack(Character Target)
        {
            HP = HP - DAMAGE;
        }

        public bool IsDead(bool isDead)
        {
            if (HP <= 0)
            {
                isDead = true;
            }
            else isDead = false;
            return isDead;
        }
        public virtual bool CheckRange(Character Target)
        {
            bool inRange;
            int range = 1;
            if (range <= 1)
            {
                inRange = true;
            }
            else inRange = false;
            return inRange;
        }

        private int DistanceTo(target)
        {
            Character.X
            Character.Y
        }
        public void Move(Movement move)
        {
            if (move = Up)
            {
                Y = Y + 1;
            }
            if (move = Down)
            {
                Y = Y - 1;
            }
            if (move = Left)
            {
                X = X - 1;
            }
            if (move = Right)
            {
                X = X + 1;
            }
            else if (move = NoMovement)
            {
                X = X;
                Y = Y;
            }
        }

        public abstract override string ToString()
        {
            return;
        }
    }
    abstract class Enemy : Character
    {
        Random rng = new Random();
        char SYMBOL;
        public Enemy(int X_CO, int Y_CO, char Symbol)
        {
            X = X_CO;
            Y = Y_CO;
            SYMBOL = Symbol;
        }
        public string ToStringEnemy()
        {
            string Output = "EnemyClassName" + "at" + X.ToString() + Y.ToString() + DAMAGE.ToString();
        }
    }

   class Goblin : Enemy
    {
        char SYMBOL;
        public Goblin(int X_CO, int Y_CO, char Symbol)
        {
            X = X_CO;
            Y = Y_CO;
            SYMBOL = Symbol;
        }
        HP = 10;
        DAMAGE = 1;
    }
    public int returnMove()
    {
        if()
    }

}
 