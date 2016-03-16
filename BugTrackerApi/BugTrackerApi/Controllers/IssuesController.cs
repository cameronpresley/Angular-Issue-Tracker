using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BugTrackerApi.Models;
using Newtonsoft.Json.Linq;

namespace BugTrackerApi.Controllers
{
    public class IssuesController : ApiController
    {
        private readonly List<Issue> _issues; 
        public IssuesController()
        {
            _issues = new List<Issue>
            {
                new Issue("Title", "Description", 1),
                new Issue("Another Title", "Description", 2)
            };
        }
        // GET: api/Issue
        public IHttpActionResult Get()
        {
            return Ok(_issues);
        }

        // GET: api/Issue/5
        public IHttpActionResult Get(int id)
        {
            if (!_issues.Any(x => x.Id == id))
                return NotFound();

            return Ok(_issues.First(x => x.Id == id));
        }

        // POST: api/Issue
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Issue/5
        public void Put(int id, [FromBody]Issue value)
        {
        }

        // DELETE: api/Issue/5
        public void Delete(int id)
        {
        }
    }
}
