using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_1
{
    class Map
    {
        Tile[,] TILE;
        Hero HERO = new Hero();
        Enemy[] ENEMIES;
        int MAPWIDTH;
        int MAPHEIGHT;
        Random RNG = new Random();

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberOfEnemies)
        {
            MAPWIDTH = RNG.Next(minWidth, maxWidth + 1);
            MAPHEIGHT = RNG.Next(minHeight, maxHeight + 1);

            Tile[,] TILE = new Tile[MAPWIDTH, MAPHEIGHT];
        }
        public void UpdateVision()
        {
            int North = Y + 1;
            int South = Y - 1;
            int East = X + 1;
            int West = X - 1;
        }
        private Tile Create()
        {
            int randomX = RNG.Next(1, MAPWIDTH);
            int randomY = RNG.Next(1, MAPHEIGHT);
        }
    }
}
