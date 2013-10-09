using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    class MainClass
    {
        public const int FieldRows = 50;
        public const int FieldCols = 75;
        
        static void Initialize(Engine engine)
        {
            Skier skier = new Skier(new FieldCoordinates(15, FieldCols / 2));
            engine.AddObject(skier);
        }

        static void Main()
        {
           
            Console.BufferHeight = Console.WindowHeight = FieldRows;
            //Console.BufferWidth = Console.WindowWidth = FieldCols;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;


            IRenderer renderer = new ConsoleRenderer(FieldRows, FieldCols);

            IUserController keyboard = new KeyboardControl();


            Engine someEngine = new Engine(renderer, keyboard);


            keyboard.OnLeftPressed += (sender, eventInfo) => 
            {
                someEngine.MoveSkierLeft();
            };
            keyboard.OnRightPressed += (sender, eventInfo) => 
            {
                someEngine.MoveSkierRight();
            };
            keyboard.OnDownPressed += (sender, eventInfo) =>
            {
                someEngine.MoveSkierDown();
            };

            Initialize(someEngine);

            Intro.PrintLogo();
            Intro.PrintNames();
            Intro.PrintGame();

            someEngine.Run();
        }

        
    }
}
