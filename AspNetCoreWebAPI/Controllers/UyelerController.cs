using Microsoft.AspNetCore.Mvc;
using NetCoreMVCEgitimi.Models;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UyelerController : ControllerBase
    {
        private readonly UyeContext _context;

        public UyelerController(UyeContext context)
        {
            _context = context;
        }

        // GET: api/<UyelerController>
        [HttpGet]
        public IEnumerable<Uye> Get()
        {
            return _context.Uyeler;
        }

        // GET api/<UyelerController>/5
        [HttpGet("{id}")]
        public Uye Get(int id)
        {
            return _context.Uyeler.Find(id);
        }

        // POST api/<UyelerController>
        [HttpPost]
        public void Post([FromBody] Uye value)
        {
            _context.Uyeler.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<UyelerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Uye value)
        {
            _context.Uyeler.Update(value);
            _context.SaveChanges();
        }

        // DELETE api/<UyelerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var model = _context.Uyeler.Find(id);
            _context.Uyeler.Remove(model);
            _context.SaveChanges();
        }
    }
}
