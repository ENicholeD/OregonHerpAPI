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
    public void Post([FromBody] TripAdvisor tripAdvisor)
    {
      _db.TripAdvisor.Add(tripAdvisor);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<TripAdvisor> Get(int id)
    {
        return _db.TripAdvisor.FirstOrDefault(entry => entry.TripAdvisorId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] TripAdvisor tripAdvisor)
    {
        tripAdvisor.TripAdvisorId = id;
        _db.Entry(tripAdvisor).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var tripToDelete = _db.TripAdvisor.FirstOrDefault(entry => entry.TripAdvisorId == id);
      _db.TripAdvisor.Remove(tripToDelete);
      _db.SaveChanges();
    }

  }
}