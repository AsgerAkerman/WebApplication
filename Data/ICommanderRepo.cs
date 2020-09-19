using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
//Som vi kender det fra andre database projekter, her skal vi bare definere de metoder som vi gerne vil lave i vores rest API, men ikke implimentere dem.
namespace WebApplication.Data
{
    public interface ICommanderRepo
    {
        //IENumerable og command er return types.
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);
    }
}
