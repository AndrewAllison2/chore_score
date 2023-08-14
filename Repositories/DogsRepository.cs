using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Repositories;

public class DogsRepository
{
    private List<Dog> dbDogs;
    public DogsRepository()
    {
        dbDogs = new List<Dog>();
        dbDogs.Add(new Dog("Finn", 4, true, true, "Ball"));
        dbDogs.Add(new Dog("Cleo", 2, false, false, "Kong"));
        dbDogs.Add(new Dog("Oliver", 5, true, false, "Bone"));
        dbDogs.Add(new Dog("Jeeter", 6, true, false, "Ball"));

    }


    internal List<Dog> GetDogs()
    {
        return dbDogs;
    }
}
