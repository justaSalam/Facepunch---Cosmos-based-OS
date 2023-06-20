using Facepunch.Commands.Main;

namespace Facepunch.Commands
{
    public class ver : Command
    {
        public ver (string name) : base (name) { }

        public override string execute(string[] args)
        {
            return "You are running the Facepunch OS_0.1a";
        }

    }
}
