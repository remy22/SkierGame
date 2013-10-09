using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public abstract class GameObject : IRenderable, IColidable, IObjectProducer
    {
        public const string CollisionName = "object";

        protected FieldCoordinates topLeft;

        public FieldCoordinates TopLeft
        {
            get
            {
                return new FieldCoordinates(topLeft.Row, topLeft.Col);
            }

            protected set
            {
                this.topLeft = new FieldCoordinates(value.Row, value.Col);
            }
        }

        protected char[,] body;

        public bool IsHit { get; protected set; }
        public bool IsGone { get; protected set; }

        protected GameObject(FieldCoordinates topLeft, char[,] body)
        {
            this.TopLeft = topLeft;

            int imageRows = body.GetLength(0);
            int imageCols = body.GetLength(1);

            this.body = this.CopyBodyMatrix(body);

            this.IsHit = false;
            this.IsGone = false;
            
        }

        public virtual void Update()
        {
            this.topLeft.Row -= 1;
            if (this.topLeft.Row < -2)
            {
                this.IsGone = true;
            }
        }

        public virtual List<FieldCoordinates> GetCollisionProfile()
        {
            List<FieldCoordinates> profile = new List<FieldCoordinates>();

            int bodyRows = this.body.GetLength(0);
            int bodyCols = this.body.GetLength(1);

            for (int row = 0; row < bodyRows; row++)
            {
                for (int col = 0; col < bodyCols; col++)
                {
                    profile.Add(new FieldCoordinates(row + this.topLeft.Row, col + this.topLeft.Col));
                }
            }

            return profile;
        }

        public virtual void RespondToCollision(CollisionData collisionData)
        {
            Console.WriteLine("");
        }

        public virtual bool CanCollideWith(string otherObjectName)
        {
            return GameObject.CollisionName == otherObjectName;
        }


        public virtual string GetCollisionName()
        {
            return GameObject.CollisionName;
        }

        char[,] CopyBodyMatrix(char[,] matrixToCopy)
        {
            int rows = matrixToCopy.GetLength(0);
            int cols = matrixToCopy.GetLength(1);

            char[,] result = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = matrixToCopy[row, col];
                }
            }

            return result;
        }

        public virtual FieldCoordinates GetTopLeft()
        {
            return this.TopLeft;
        }

        public virtual char[,] GetImage()
        {
            return this.CopyBodyMatrix(this.body);
        }

        public virtual IEnumerable<GameObject> ProduceObjects()
        {
            return new List<GameObject>();
        }
    }
}
