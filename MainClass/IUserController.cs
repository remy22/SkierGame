using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public interface IUserController
    {
        event EventHandler OnLeftPressed;

        event EventHandler OnRightPressed;

        event EventHandler OnDownPressed;

        void ProcessInput();
    }
}
