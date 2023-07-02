using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> _characters = new List<Character>
        {
            new Character(),
            new Character{ Id = 1, Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(_characters);
        }

        [HttpGet("GetSingle{id}")]
        public ActionResult<Character> GetFirst(int id)
        {
            return Ok(_characters.FirstOrDefault(c => c.Id == id));
        }
    }
}