using Terminal.Gui;
using Wanderer.Factories;
using Wanderer.TerminalGui;

namespace TestWandererInstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            var worldFactory = new WorldFactory();
            
            Application.Init();
                            
            var ui = new MainWindow(worldFactory);
            Application.Top.Add(ui);
            Application.Run();             
        }
    }
}