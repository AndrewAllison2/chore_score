using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Services;

public class DogsService
{
    private readonly DogsRepository _dogsRepository;

    public DogsService(DogsRepository dogsRepository)
    {
        _dogsRepository = dogsRepository;
    }

    internal Dog CreateDog(Dog dogData)
    {
        Dog dog = _dogsRepository.CreateDog(dogData);
        return dog;
    }

    internal Dog GetDogByName(string dogName)
    {
        Dog dog = _dogsRepository.GetDogByName(dogName);
        return dog;
    }

    internal List<Dog> GetDogs()
    {
        List<Dog> dogs = _dogsRepository.GetDogs();
        return dogs;
    }

    internal Dog RemoveDog(string dogName)
    {
        Dog dog = _dogsRepository.RemoveDog(dogName);
        return dog;
    }
}
