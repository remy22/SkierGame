using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public interface IColidable
    {
        bool CanCollideWith(string objectType);

        List<FieldCoordinates> GetCollisionProfile();

        void RespondToCollision(CollisionData collisionData);

        string GetCollisionName();
    }
}
