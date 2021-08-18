using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_Rpg.Dtos.Fight
{
    public class HighscoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fights { get; set; }
        public int Defeats { get; set; }
        public int Victories { get; set; }
    }
}
