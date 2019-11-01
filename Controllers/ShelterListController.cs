using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShelterListController : ControllerBase
  {
    private AnimalShelterContext _db;

    public ShelterListController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ShelterList>> Get(string name, string animalType, string breed, string gender, int age, string kennelNumber, string description)
    {
      var query = _db.ShelterList.AsQueryable(); 
      if(name !=null)
      {
        query = query.Where(entry=>entry.Name == name);
      }

      if(animalType !=null)
      {
        query = query.Where(entry=>entry.AnimalType == animalType);
      }
        
        if(breed !=null)
      {
        query = query.Where(entry=>entry.Breed == breed);
      }
      if(gender !=null)
      {
        query = query.Where(entry=>entry.Gender == gender);
      }
        if(age !=0)
      {
        query = query.Where(entry=>entry.Age == age);
      }
      if(kennelNumber !=null)
      {
        query = query.Where(entry=>entry.KennelNumber == kennelNumber);
      }
      if(description !=null)
      {
        query = query.Where(entry=>entry.Description == description);
      }
      return query.ToList();
    }
    

    [HttpPost]
    public void Post([FromBody] ShelterList shelterList)
    {
      _db.ShelterList.Add(shelterList);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<ShelterList> Get(int id)
    {
        return _db.ShelterList.FirstOrDefault(entry => entry.ShelterListId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] ShelterList shelterList)
    {
        shelterList.ShelterListId = id;
        _db.Entry(shelterList).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animaltoDelete = _db.ShelterList.FirstOrDefault(entry => entry.ShelterListId == id);
      _db.ShelterList.Remove(animaltoDelete);
      _db.SaveChanges();
    }

  }
}