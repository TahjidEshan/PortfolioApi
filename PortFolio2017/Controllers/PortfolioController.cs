using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortFolio2017.DAL;
using PortFolio2017.Models;
using PortFolio2017.Services;

namespace PortFolio2017.Controllers
{
    [Route("api/[controller]")]
    public class PortfolioController : Controller
    {
        protected IBaseService BaseService { get; set; }

        public PortfolioController(IBaseService BaseService)
        {
            this.BaseService = BaseService;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return BaseService.GetAllEmails().Select(x=>x.EmailAddress);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
