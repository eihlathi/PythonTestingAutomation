using AspNetWebApiDemo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Person> GetPersons()
        {
            // read the contents of the Persons.csv file to memory
            List<Person> persons = System.IO.File.ReadAllLines("Persons.csv")
                .Skip(1)
                .Select(v => v.Split(","))
                .Select(v => new Person(int.Parse(v[0]), v[1], v[2]))
                .ToList();

            return persons;
        }
    }
}
