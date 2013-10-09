using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class Engine
    {
        IRenderer renderer;
        IUserController userInterface;
        List<GameObject> allObjects;


        int generator;
        int treeGenerator;
        int decorationGenerator;
        int bonusGenerator;


        int biggestWidthOfElement = 5;
        Skier skier;
        

        public Engine(IRenderer renderer, IUserController userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
        }

        public void AddObject(GameObject obj)
        {
            this.allObjects.Add(obj);
            if (obj is Skier)
            {
                AddSkier(obj);
            }
        }

        private void AddSkier(GameObject obj)
        {
            this.skier = obj as Skier;
        }

        public virtual void MoveSkierLeft()
        {
            this.skier.MoveLeft();
        }

        public virtual void MoveSkierRight()
        {
            this.skier.MoveRight();
        }

        public virtual void MoveSkierDown()
        {
            this.skier.MoveDown();
        }

        public virtual void Run()
        {
            Score.GameScore = 0;
            var key = Console.ReadKey();
            int putNewObstacle = 0;
            int putNewFlag = 0;
            while (true)
            {
                Score.GameScore++;
                if (this.skier.IsDead)
                {
                    Score.GameScore = 0;
                    skier.Update();
                    while (this.skier.IsDead)
                    {
                        if (Console.KeyAvailable)
                        {
                            this.skier.IsDead = false;
                            break;
                        }
                    }
                }
                putNewObstacle++;
                putNewFlag++;


                CollisionHandler.HandleCollision(this.skier, this.allObjects);

                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(50);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();


                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                if (putNewObstacle == 3)
                {
                    putNewObstacle = 0;

                    generator = RandomGenerator.randomGenerator.Next(1, MainClass.FieldCols - biggestWidthOfElement);
                    treeGenerator = RandomGenerator.randomGenerator.Next(1, 5);
                    this.AddObject(new Tree(new FieldCoordinates(MainClass.FieldRows - 3, generator), treeGenerator));


                    decorationGenerator = RandomGenerator.randomGenerator.Next(1, MainClass.FieldCols);
                    this.AddObject(new Decoration(new FieldCoordinates(1, decorationGenerator)));
                    this.AddObject(new Decoration(new FieldCoordinates(decorationGenerator, 1)));
                }
                if (putNewFlag == 30)
                {
                    putNewFlag = 0;

                    bonusGenerator = RandomGenerator.randomGenerator.Next(15, MainClass.FieldCols - 15);
                    this.AddObject(new Bonus(new FieldCoordinates(MainClass.FieldRows - 3, bonusGenerator)));

                }


                //Some collission actions we must write 

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }
                var bonusObjects =
                    from someObject in this.allObjects
                    where (("bonus").Equals(someObject.GetCollisionName())  && (someObject.IsGone == true))
                    select someObject;
                foreach (Bonus someObject in bonusObjects)
                {
                    Score.GameScore += 100;
                }
       


                this.allObjects.RemoveAll(obj => obj.IsGone);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }

        }
        }

    }
}