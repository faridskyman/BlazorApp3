using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp3.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp3.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")] //to call this is controller +  route so its person/all
        public IEnumerable<PersonModel> GetPeople()
        {
            return new List<PersonModel>
            {
                new PersonModel{ FirstName="Farid", LastName ="Mohd Ismail", AccountBalance= 19.45M },
                new PersonModel{ FirstName="Ruzana", LastName ="Binte Farid", AccountBalance= 109.25M },
                new PersonModel{ FirstName="Ibrahim", LastName ="Binte Farid", AccountBalance= 92.55M },
                new PersonModel{ FirstName="Insyirah", LastName ="Binte Farid", AccountBalance= 16.05M }
            };
        }

        [HttpPost]
        public void Post(PersonModel person)
        {
            //leave blank for now
        }
    }
}