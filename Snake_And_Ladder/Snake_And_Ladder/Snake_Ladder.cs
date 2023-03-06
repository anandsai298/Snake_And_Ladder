using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    public class Snake_Ladder
    {
        int Player_Position = 0;
        Random random = new Random();
        public void Dice_role()
        {
            int Die = random.Next(1, 7);
            Console.WriteLine(Die);
        }
    }
}
