using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class Skier : GameObject
    {
        public new const string CollisionName = "skier";
        public bool IsDead { get; set; }


        public Skier(FieldCoordinates topLeft)
            : base(topLeft, new char[,] { { '|', '|' } })
        {
            this.IsDead = false;
        }

        public void MoveLeft()
        {
            this.body = new char[,] { { '/', '/' } };
            this.topLeft.Col--;
            if (this.topLeft.Col < 0)
            {
                this.topLeft.Col = MainClass.FieldCols - 2;
            }
        }

        public void MoveRight()
        {
            this.body = new char[,] { { '\\', '\\' } };
            this.topLeft.Col++;
            if (this.topLeft.Col > MainClass.FieldCols - 2)
            {
                this.topLeft.Col = 1;
            }
        }

        public void MoveDown()
        {
            this.body = new char[,] { { '|', '|' } };
            this.topLeft.Col = topLeft.Col;
        }

        public override string GetCollisionName()
        {
            return Skier.CollisionName;
        }

        public override bool CanCollideWith(string otherObjectName)
        {
            return otherObjectName == "tree";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
                this.IsDead = true;
        }

        public override void Update()
        {
        }
    }
}
