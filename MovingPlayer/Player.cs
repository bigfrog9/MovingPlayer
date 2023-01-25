using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingPlayer
{
    internal class Player
    {
        private int x = 10;
        private int y = 10;
        public bool gameOver = false;

        public void Update()
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.W) y -= 1;
            if (input.Key == ConsoleKey.S) y += 1;
            if (input.Key == ConsoleKey.A) x -= 1;
            if (input.Key == ConsoleKey.D) x += 1;

            if (input.Key == ConsoleKey.Escape) gameOver = true;

        }

        public void Draw()
        {
            Console.Clear();

            Console.SetCursorPosition(x, y);
            Console.Write("+");
        }
    }
}
