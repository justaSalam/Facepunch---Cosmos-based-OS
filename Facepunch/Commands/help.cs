using Facepunch.Commands.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facepunch.Commands
{
    public class help : Command
    {
        public help(string name) : base(name) { }

        public override string execute(string[] args)
        {
            CommandManager manager = new CommandManager();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Avaible commands:").AppendLine();
            foreach (Command cmd in manager.commands) 
            {
                stringBuilder.Append(cmd.name).AppendLine();
            }

            Console.WriteLine(stringBuilder.ToString());
            
            return "";
        }

    }
}
