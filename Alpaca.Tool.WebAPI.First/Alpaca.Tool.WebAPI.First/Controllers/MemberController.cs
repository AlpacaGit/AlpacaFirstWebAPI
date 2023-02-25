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
        public IEnumerable<MemberInfo> Get()
        {
            var memberList = _context.M_Member.ToArray<Models.M_Member>();
            List<MemberInfo> memberInfoList = new List<MemberInfo>();
            foreach (Models.M_Member member in memberList)
            {
                MemberInfo aMember 
                    = new(member.MemberID, member.MemberName,member.MemberNameKana,member.MemberNameEng,
                    member.ImageColorID,
                    member.Grade,member.Age,member.BirthDay,member.Height,member.BloodType);
                memberInfoList.Add(aMember);
            }
            return memberInfoList;
        }

        public record MemberInfo(int MemberID, string MemberName, string MemberNameKana = "", string MemberNameEng = ""
                , int? ImageColorID = null
                , string? Grade = null, short? Age = null, string? BirthDay = null, int? Height = null, string? BloodType = null)
        {
            public int MemberID { get; } = MemberID;
            public string MemberName { get; } = MemberName;
            public string MemberNameKana { get; } = MemberNameKana;
            public string MemberNameEng { get; } = MemberNameEng;
            public int? ImageColorID { get; } = ImageColorID;
            public string? Grade { get; } = Grade;
            public short? Age { get; } = Age;
            public string? BirthDay { get; } = BirthDay;
            public int? Height { get; } = Height;
            public string? BloodType { get; } = BloodType;
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
