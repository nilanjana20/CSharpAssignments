using System;

namespace Assignments
{
    internal class SnakeLadder
    {
        private int InitialPosition = 0;
        private int CurrentPosition;

        public static void Solution()
        {
            SnakeLadder app = new SnakeLadder();
            app.CurrentPosition = app.InitialPosition;
            Console.WriteLine($"current position is {app.CurrentPosition}");
        }
    }
}