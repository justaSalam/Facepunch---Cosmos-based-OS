using Facepunch.Commands.Main;
using Cosmos.System;
using System.Threading;
using sys = System;

namespace Facepunch.Commands
{
    public class shutdown : Command
    {
        public shutdown(string name) : base(name) { }

        public override string execute(string[] args)
        {
            if(args.Length == 0)
            {
                sys.Console.WriteLine("No arguments");
                sys.Console.WriteLine("-r, -s => shutdown, restart");
                sys.Console.WriteLine("-f => force shutown/restart");
            }
            else  
            {
                switch(args[0])
                {
                    case "-s":
                        if(args.Length == 2)
                        {
                            if (args[1].Equals("-f"))
                            {
                                sys.Console.Clear();
                                sys.Console.WriteLine("System will be forcibly shut down!");
                                Power.Shutdown();
                            }
                        }
                        else
                        {
                            sys.Console.Clear();
                            sys.Console.WriteLine("System will be shut down in 5 sec!");
                            Thread.Sleep(5000);
                            Power.Shutdown();
                        }
                        break;

                    case "-r":
                        if (args.Length == 2)
                        {
                            if (args[1].Equals("-f"))
                            {
                                sys.Console.Clear();
                                sys.Console.WriteLine("System will be forcibly restarted!");
                                Power.Reboot();
                            }

                        }
                        else
                        {
                            sys.Console.Clear();
                            sys.Console.WriteLine("System will be restarted in 5 sec!");
                            Thread.Sleep(5000);
                            Power.Reboot();
                        }
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
