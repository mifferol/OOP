using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitsController : Controller
    {
        private readonly IVisits objvisits;

        public VisitsController(IVisits _objvisits)
        {
            objvisits = _objvisits;
        }

        [HttpGet]
        //[Route("Index")]
        public IEnumerable<Visits> Get()
        {
            return objvisits.GetAllVisits();
        }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] Visits visits)
        {
            return objvisits.AddVisits(visits);
        }

        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody]Visits visits)
        {
            return objvisits.UpdateVisits(visits);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public int Delete(int id)
        {
            return objvisits.DeleteVisits(id);
        }


        [HttpGet]
        [Route("Details/{id}")]
        public Visits Details(int id)
        {
            return objvisits.GetVisitsData(id);
        }
    }
}
