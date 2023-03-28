using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIC_.Models
{
    public class Character
    {
        public int id {get;set;}
        public string Name{get;set;}="defaut";
        public int HitPoints { get; set; }=100;
        public int Strength { get; set; }=10;
        public int Defense { get; set; }=10;
        public int Intelligence { get; set; }=10;
        public Categories cat { get; set; } = Categories.Fighter;
    }
}