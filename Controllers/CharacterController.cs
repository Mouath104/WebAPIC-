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
        private readonly ICharacterService _CharService;

        public CharacterController(ICharacterService CharService)
        {
            _CharService = CharService;
        }
        //no need to put [Get], as the API knows it's a get method as it contains "Get" word
        // [HttpGet]
        // public ActionResult<Character> Get(){
        //     return Ok(assasins[0]);
        // }
        [HttpGet("{pk}")]
        public async Task<ActionResult<Character>> Getsingle(int pk){
            return Ok(await _CharService.Getsingle(pk));
        }

        [HttpGet("getall")]
        public async Task<ActionResult<ServiceResponse<Character>>> Getall(){
            return Ok(await _CharService.Getallser());
        }

        [HttpPost]
        public void AddChar (Character charr){
            _CharService.AddChar(charr);
        }

        [HttpPut("{updateChar}")]
        public void UpdateChar(Character charr){
            _CharService.UpdateChar(charr);
        }
        [HttpDelete("{pk}")]
        public ActionResult<bool> DeleteCharCont(int pk){
            return Ok(_CharService.DeleteChar(pk));
        }
    }
}

