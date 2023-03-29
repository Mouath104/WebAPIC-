using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIC_.Services
{
    public interface ICharacterService
    {
        public List<Character> Getallser();
        public void AddChar (Character charr);
        public Character Getsingle(int pk);
    }
}