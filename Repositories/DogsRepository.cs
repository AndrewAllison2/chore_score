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
        dbDogs.Add(new Dog("Jeeter", 6, true, false, "Rope"));

    }

    internal Dog CreateDog(Dog dogData)
    {
        dbDogs.Add(dogData);
        return dogData;
    }

    internal Dog GetDogByName(string dogName)
    {

        // this should be done in the service
        Dog foundDog = dbDogs.Find(d => d.Name.ToLower() == dogName.ToLower());
        return foundDog;
    }

    internal List<Dog> GetDogs()
    {
        return dbDogs;
    }

    internal Dog RemoveDog(string dogName)
    {
        Dog dogToRemove = GetDogByName(dogName);
        dbDogs.Remove(dogToRemove);
        return dogToRemove;
    }
}
