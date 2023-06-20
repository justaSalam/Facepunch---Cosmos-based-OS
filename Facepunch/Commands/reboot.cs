using Facepunch.Commands.Main;
using Cosmos.System;
using System.Threading;
using sys = System;

namespace Facepunch.Commands
{
    public class reboot : Command
    {
        public reboot(string name) : base(name) { }

        public override string execute(string[] args)
        {
            if (args.Length == 0)
            {
                sys.Console.WriteLine("System is restarting in 5 sec!");
                Thread.Sleep(5000);
                Power.Shutdown();
            }
            else
            {
                switch (args[0])
                {
                    case "-f":
                        sys.Console.Clear();

                        sys.Console.WriteLine("System will be forcibly restarted!");
                        Power.Shutdown();
                        break;

                    default:
                        sys.Console.WriteLine("Invalid argument!");
                        break;
                }
            }
            return "";
        }

    }
}
