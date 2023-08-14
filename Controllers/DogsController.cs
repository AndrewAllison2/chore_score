using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chore_score.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class DogsController : ControllerBase
    {
    private readonly DogsService _dogsService;

    public DogsController(DogsService dogsService)
    {
        _dogsService = dogsService;
    }

    [HttpGet]
    public ActionResult<List<Dog>> GetDogs()
    {
        try
        {
            List<Dog> dogs = _dogsService.GetDogs();
            return Ok(dogs);
        }
        catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
    }

    [HttpGet("{dogName}")]
    public ActionResult<Dog> GetDogByName(string dogName)
    {
        try
        {
            Dog dog = _dogsService.GetDogByName(dogName);
            return Ok(dog);
        }
        catch (Exception e)
            {
                return BadRequest(e.Message);
            }
    }

    [HttpPost]
    public ActionResult<Dog> CreateDog([FromBody] Dog dogData)
    {
        try
            {
                Dog dog = _dogsService.CreateDog(dogData);
                return dog;
            }
        catch (Exception e)
            {
                return BadRequest(e.Message);
            }
    }

    [HttpDelete("{dogName}")]
    public ActionResult<string> RemoveDog(string dogName)
    {
        try
        {
            Dog dog = _dogsService.RemoveDog(dogName);
            return Ok($"{dog.Name} was removed from the list of good boys.");
        }
        catch (Exception e)
            {
                return BadRequest(e.Message);
            }
    }
    }
