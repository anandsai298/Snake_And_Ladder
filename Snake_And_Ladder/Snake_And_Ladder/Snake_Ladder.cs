using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    public class Snake_Ladder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2,WINNING_POSITION=100;
        int Player_Position = 0, count = 0;
        Random random = new Random();
        public int Dice_Role()
        {
            int Die = random.Next(1, 7);
            count++;
            Console.WriteLine("die role ---->" + Die);
            return Die;
        }
        public void Game()
        {
            while(this.Player_Position < WINNING_POSITION)//player position moves unltil 100
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
                        int DiceRole = Dice_Role();//if player position is lessthan 0 then starts from position 0
                        if (this.Player_Position - DiceRole > 0)
                            this.Player_Position -= DiceRole;
                        else
                            this.Player_Position = 0;
                        break;
                }
                Console.WriteLine("player position -------> " + Player_Position);
            }
            if (this.Player_Position == WINNING_POSITION)
            Console.WriteLine("player position -------> " + Player_Position);
            Console.WriteLine("die count -----> " + count);
        }
    }
}
