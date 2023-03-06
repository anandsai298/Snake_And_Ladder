using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    public class Snake_Ladder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int Player_Position = 0;
        Random random = new Random();
        public int Dice_Role()
        {
            int Die = random.Next(1, 7);
            Console.WriteLine(Die);
            return Die;
        }
        public void Game()
        {
            int option = random.Next(0, 3);
            switch(option)
            {
                case NO_PLAY://no change in position
                    break;
                case LADDER://increses player position by dicerole number
                    this.Player_Position += Dice_Role();
                    break;
                case SNAKE://decreases player position by dicerole number
                    this.Player_Position -= Dice_Role();
                    break;
            }
        }
    }
}
