using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class Obstacle : GameObject
    {
        public Obstacle(FieldCoordinates topLeft, char[,] body)
            : base(topLeft, body)
        { 
        }
    }
}
