using MapsterMappingExample.Models;

namespace MapsterMappingExample
{
    public class DataService
    {
        public static List<GameCharacter> GetData()
        {
            var gameCharacters = new List<GameCharacter>
            {
                new GameCharacter
                {
                    Id = 1,
                    Name = "Ellie",
                    Location = new Location
                    {
                        Name = "Jackson",
                        Description = "A well-protected settlement in Wyoming."
                    }
                },
                new GameCharacter
                {
                    Id = 2,
                    Name = "Joel",
                    Location = new Location
                    {
                        Name = "Boston",
                        Description = "A city in ruins with dangerous factions."
                    }
                }
            };
            return gameCharacters;
        }
    }
}
