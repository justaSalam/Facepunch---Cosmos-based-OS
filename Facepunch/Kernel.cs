using Facepunch.Commands.Main;
using System;
using Sys = Cosmos.System;

namespace Facepunch
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager commandManager;
        
        protected override void BeforeRun()
        {
            Console.Clear(); 
            Console.WriteLine("Facepunch OS booted successfully.");
            this.commandManager = new CommandManager();
            
        }

        protected override void Run()
        {
            string response = this.commandManager.processCommand(Console.ReadLine());
            Console.WriteLine(response); ;
            
        }
    }
}
