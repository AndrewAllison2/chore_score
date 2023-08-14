
namespace chore_score.Models;

    public class Dog
    {
        public string Name{ get; set; }
        public int Age { get; set; }
        public bool HasShortHair { get; set; }
        public bool Drools { get; set; }
        public string FavoriteToy { get; set; }

        public Dog(string name, int age, bool hasShortHair, bool drools, string favoriteToy)
        {
        Name = name;
        Age = age;
        HasShortHair = hasShortHair;
        Drools = drools;
        FavoriteToy = favoriteToy;
        }
    }
    
        
    
