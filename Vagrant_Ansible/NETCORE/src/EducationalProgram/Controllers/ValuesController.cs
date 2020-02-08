using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationalProgram.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EducationalProgram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly BloggingContext _bloggingContext;

        public ValuesController(BloggingContext bloggingContext)
        {
            _bloggingContext = bloggingContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Blog>> Get()
        {
            var blogs = _bloggingContext.Blogs
                .ToList();

            return blogs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
