using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;  
namespace WebAPIC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // this is the rout that calls the controller indicates api/Character
    public class CharacterController : ControllerBase
    {
        private static List<Character> assasins = new List<Character> {
            new Character(),
            new Character{id = 1,Name = "default2"}
        };

        //no need to put [Get], as the API knows it's a get method as it contains "Get" word
        // [HttpGet]
        // public ActionResult<Character> Get(){
        //     return Ok(assasins[0]);
        // }
        [HttpGet("{pk}")]
        public ActionResult<Character> Getsingle(int pk){
            return Ok(assasins.FirstOrDefault(x => x.id == pk));
        }

        [HttpGet("getall")]
        public ActionResult<Character> Getall(){
            return Ok(assasins);
        }

        [HttpPost]
        public ActionResult<List<Character>> AddChar (Character charr){
            assasins.Add(charr);
            return Ok(assasins);
        }
    }
}