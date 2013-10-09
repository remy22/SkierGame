using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class Bonus : GameObject
    {
        public new const string CollisionName = "bonus"
            ;
        protected static char[,] flag = new char[,]
        {
        {'-','-','|',},
        {'-','-','|',},
        {' ',' ','|',},
        };

        public Bonus(FieldCoordinates topLeft)
            : base(topLeft, flag)
        { 
        }

        public override bool CanCollideWith(string otherObjectName)
        {
            return otherObjectName == "skier";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsGone = true;
            //Score.GameScore += 100;
        }

        public override string GetCollisionName()
        {
            return Bonus.CollisionName;
        }


    }
}
