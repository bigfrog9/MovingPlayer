using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.CursorVisible = false;

            while (player.gameOver==false)
            {

                player.Update();
                player.Draw();

            }
        }
    }
}
