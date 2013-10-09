using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class CollisionData
    {

        // Collision date gives information about obstacle`s type

        public readonly string CollisionName;

        public CollisionData(string collisionName)
        {
            this.CollisionName = collisionName;
        }

    }
}
