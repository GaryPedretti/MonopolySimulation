using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class MonopolyConsoleUI : IMonopolyUI
    {
        public void SendUIMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
