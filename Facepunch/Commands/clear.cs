using Facepunch.Commands.Main;

namespace Facepunch.Commands
{
    public class clear : Command
    {
        public clear(string name) : base(name) { }

        public override string execute(string[] args)
        {
            System.Console.Clear();
            return "";
        }

    }
}
