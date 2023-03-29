using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIC_.Services
{
    public interface ICharacterService
    {
        public Task<List<Character>> Getallser();
        public void AddChar (Character charr);
        public Task<Character> Getsingle(int pk);
    }
}