using Domain;

namespace Application.CharacterCreation.Abstractions.Models;

public sealed class Character
{
        public Abilities Abilities { get; set; }
                = new();
        
        public Attributes Attributes { get; set; }
                = new();

        public Clan Clan { get; set; }

        public PersonalityArchtype Demeanor { get; set; }

        public Dicipline[] Diciplines { get; set; }

        public int Experience { get; set; }
        
        public byte Generation { get; set; }

        public string Name { get; set; }
        
        public PersonalityArchtype Nature { get; set; }

        public string Sire { get; set; }
}