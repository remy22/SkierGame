using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class Tree : Obstacle
    {
        protected static char[,] bigTree = new char[,]
        {
        {' ',' ','^',' ',' '},
        {' ','^',' ','^',' '},
        {'^',' ','^',' ','^'},
        };

        protected static char[,] smallTree = new char[,]
        {
        {' ','^',' '},
        {'^',' ','^'}
        };

        protected static char[,] rock = new[,] { { 'o' } };

        public new const string CollisionName = "three";

        public Tree(FieldCoordinates topLeft, int option)
            : base(topLeft, smallTree)
        {
            if (option == 2)
            {
                base.body = bigTree;
            }
            else if (option == 3)
            {
                base.body = rock;
            }
            else if (option == 1)
            {
                base.body = smallTree;
            }
        }

        public override bool CanCollideWith(string otherObjectName)
        {
            return otherObjectName == "skier";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsHit = true;
        }

        public override string GetCollisionName()
        {
            return Tree.CollisionName;
        }
    }
}
