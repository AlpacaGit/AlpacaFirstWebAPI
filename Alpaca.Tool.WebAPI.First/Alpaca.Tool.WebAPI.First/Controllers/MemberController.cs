using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Alpaca.Tool.WebAPI.First.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly Data.AlpacaToolWebAPIFirstContext _context;
        public MemberController(Data.AlpacaToolWebAPIFirstContext alpacaToolWebAPIFirstContext)
        {
            _context = alpacaToolWebAPIFirstContext;
        }

        // GET: api/<MemberController>
        [HttpGet]
        public IEnumerable<Models.M_Member> Get()
        {
            return _context.M_Member.ToArray<Models.M_Member>();
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public Models.M_Member? Get(int id)
        {
            Models.M_Member? member = _context.M_Member.Where(x => x.MemberID == id).FirstOrDefault();
            return member;
        }

        // POST api/<MemberController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MemberController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
