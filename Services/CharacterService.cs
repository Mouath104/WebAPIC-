using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIC_.Services
{
    public class CharacterService : ICharacterService
    {
            private static List<Character> assasins = new List<Character> {
            new Character(),
            new Character{id = 1,Name = "default2"}
        };

        public void AddChar(Character charr)
        {
            assasins.Add(charr);
        }

        public List<Character> Getallser()
        {
            return assasins;
        }

        public Character Getsingle(int pk)
        {
            var charr = assasins.FirstOrDefault(x => x.id == pk);

            if (charr is not null){
                return charr;
            }
            throw new Exception("Character Not Found!");
        }
    }
}