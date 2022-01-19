using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class SnakeLadderUc2
    {
        private int InitialPosition= 0;
        private int CurrentPosition;

        private int RollDice()
        {
            Random random = new Random();
            return random.Next(0, 7);
        }

        public static void Solution()
        {
            SnakeLadderUc2 app = new SnakeLadderUc2();
            app.CurrentPosition = app.InitialPosition;
            Console.WriteLine($"Current position is: {app.CurrentPosition}");
            Console.WriteLine($"After rolling dice number is: {app.RollDice()}");
        }
    }
}