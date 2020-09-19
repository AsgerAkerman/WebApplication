using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
//Her implimentere vi rent faktisk vores interface fra før. ':' betyder impliments i C#. Men den snakker ikke direkte med databasen, det er bare noget hardcoded data.
namespace WebApplication.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
          {
              new Command { Id = 0, HowTo = "hej", Line = "Line", Platform = "Platform" },
              new Command { Id = 1, HowTo = "hej1", Line = "Line1", Platform = "Platform1" }
        };
            return commands;

        }
        //returenere bare et command object udfra ID
        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "hej", Line = "Line", Platform = "Platform" };
        }
    }
}
