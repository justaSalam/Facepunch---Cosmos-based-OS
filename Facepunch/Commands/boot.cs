using Facepunch.Commands.Main;
using Cosmos.System.Graphics;
using System;

namespace Facepunch.Commands
{
    public class boot : Command
    {
        public boot(string name) : base(name) { }
        public override string execute(string[] args)
        {            
            Console.WriteLine("booting");
            return "";
        }

    }
}
