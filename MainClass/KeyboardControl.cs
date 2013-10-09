using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class KeyboardControl : IUserController
    {
        public void ProcessInput()
        {
            while (Console.KeyAvailable)
            {
                var pressedKey = Console.ReadKey();
                if (pressedKey.Key.Equals(ConsoleKey.LeftArrow))
                {
                    if (this.OnLeftPressed != null)
                    {
                        this.OnLeftPressed(this, new EventArgs());
                    }
                }

                if (pressedKey.Key.Equals(ConsoleKey.RightArrow))
                {
                    if (this.OnRightPressed != null)
                    {
                        this.OnRightPressed(this, new EventArgs());
                    }
                }

                if (pressedKey.Key.Equals(ConsoleKey.DownArrow))
                {
                    if (this.OnDownPressed != null)
                    {
                        this.OnDownPressed(this, new EventArgs());
                    }
                }

                else if (pressedKey.Key == ConsoleKey.Spacebar)
                {
                    pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                    }
                }
            }
        }

        public event EventHandler OnLeftPressed;

        public event EventHandler OnRightPressed;

        public event EventHandler OnDownPressed;

    }
}
