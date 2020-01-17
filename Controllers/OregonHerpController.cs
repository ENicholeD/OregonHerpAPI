using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OregonHerp.Models;
using Microsoft.EntityFrameworkCore;

namespace OregonHerp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class HerpListController : ControllerBase
  {
    private OregonHerpContext _db;

    public HerpListController(OregonHerpContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<HerpList>> Get(string name, string animalType, string breed, string gender, string age, string kennelNumber, string description)
    {
      var query = _db.HerpList.AsQueryable(); 
      
      return query.ToList();
    }
    

    [HttpPost]
    public void Post([FromBody] HerpList herpList)
    {
      _db.HerpList.Add(herpList);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<HerpList> Get(int id)
    {
        return _db.HerpList.FirstOrDefault(entry => entry.HerpListId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] HerpList herpList)
    {
        herpList.HerpListId = id;
        _db.Entry(herpList).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animaltoDelete = _db.HerpList.FirstOrDefault(entry => entry.HerpListId == id);
      _db.HerpList.Remove(animaltoDelete);
      _db.SaveChanges();
    }

  }
}