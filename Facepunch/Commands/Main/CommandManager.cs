using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facepunch.Commands.Main
{
    public class CommandManager
    {
        public List<Command> commands;

        public CommandManager()
        {
            this.commands = new List<Command>();
            this.commands.Add(new ver("ver"));
            this.commands.Add(new shutdown("shutdown"));
            this.commands.Add(new clear("clear"));

            this.commands.Add(new help("help"));//Should be the last command to be registered
        }

        public string processCommand(string command)
        {
            string[] split = command.Split(" ");

            string start = split[0]; //The command we want to execute 
            List<string> args = new List<string>();

            int counter = 0;
            foreach (string arg in split)
            {
                if (!counter.Equals(0)) args.Add(arg);

                counter++;
            }

            foreach (Command cmd in commands)
            {
                if (cmd.name.Equals(start)) return cmd.execute(args.ToArray());

            }

            return $"Command {start} does not exist!";

        }

    }
}
