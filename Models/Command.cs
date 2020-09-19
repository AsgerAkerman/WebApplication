using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Det her er domæne modellen for APIet. Her skal vi smide vores tabeller ind.
namespace WebApplication.Models
{
    public class Command
    {

        public int Id { get; set; }
        public String HowTo { get; set; }
        public String Line { get; set; }
        public String Platform { get; set; }

    }
}

