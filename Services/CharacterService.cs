using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAPIC_.Data;

namespace WebAPIC_.Services
{

    public class CharacterService : ICharacterService
    {

        private readonly DataContext _context;
        // private readonly IMapper _mapper;
        // public CharacterService(IMapper mapper,DataContext context)
        // {   
        //     _context = context;
        //     _mapper = mapper;
        // }
        public CharacterService(DataContext context)
        {   
            _context = context;
        }

        private static List<Character> assasins = new List<Character> {
            new Character(),
            new Character{id = 1,Name = "default2"}
        };
        

        public void AddChar(Character charr)
        {
            var serviceresponse = new ServiceResponse<List<Character>>();
            assasins.Add(charr);
            serviceresponse.Data = assasins;
            // return serviceresponse;
        }

        public async Task<List<Character>> Getallser()
        {
            var dbCharacters = await _context.characters.ToListAsync();
            return dbCharacters;
        }

        public async Task<Character> Getsingle(int pk)
        {
            var dbcharr = await _context.characters.FirstOrDefaultAsync(c => c.id == pk);
            // var serviceresponse = new ServiceResponse<Character>();
            // serviceresponse.Data = charr;

            return dbcharr; // no need for below, as the Data could be nullable
            // if (charr is not null){
            //     return  serviceresponse;
            // }
            // throw new Exception("Character Not Found!");
        }

         public void UpdateChar (Character updatedChar){

            var charr = assasins.FirstOrDefault(x => x.id == updatedChar.id );
            charr.Name = updatedChar.Name;
            charr.HitPoints = updatedChar.HitPoints;
            charr.Strength = updatedChar.Strength;
            charr.Defense = updatedChar.Defense;
            charr.Intelligence = updatedChar.Intelligence;
            charr.cat = updatedChar.cat;

         }
         public bool DeleteChar (int pk){
            var charr = assasins.FirstOrDefault(x => x.id == pk );
            if (charr is not null){
                assasins.Remove(charr);
                return true;
            }
            else{
                return false;
            }
         }
    }
}