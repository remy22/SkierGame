using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class Decoration : GameObject
    {
        public new const string CollisionName = "decoration";

        public Decoration(FieldCoordinates topLeft)
            : base(topLeft, new char[,] { { '*' } })
        { 
        
        }

        //Still can be rewriten for some collition effects
        public override void Update()
        {
            this.topLeft.Row += 1;
            this.topLeft.Col += 1;
            if (this.topLeft.Row > MainClass.FieldRows)
            {
                this.IsGone = true;
            }
        }


    }
}
