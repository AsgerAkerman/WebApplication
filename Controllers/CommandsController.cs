using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Models;
//controller klassen for commands, hold over controllerBase så man kan se hvad den gør.
//Route er bare vores endpoint URL for APIet
namespace WebApplication.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        //lige nedenfor er noget dependency injection. 
        //Inde i startupklassen har vi givet hvilken klasse vi skal injecte når vi får følgende constructor
        //dvs der hvor der står repository vil vi dependency injecte den klassse som giver inde i startup
        //private readonlyen er bare for at få en variabel som vi kan sætte vores injectede repo til.
        private readonly ICommanderRepo _repository;
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
         //nedenfor er vores første httpkald
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);

        }
        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
            
        }
    }
}
