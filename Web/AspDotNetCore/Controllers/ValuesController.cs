using System.Collections.Generic;
using System.Linq;
using AspDotNetCore.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IDataProtector dataProtector;

        public ValuesController(IDataProtectionProvider provider)
        {
            dataProtector = provider.CreateProtector("MyIdProtector");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = GetUsers();
            var outPut = users.Select(x => new { Id = dataProtector.Protect(x.Id.ToString()), x.Name });

            return Ok(outPut);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var originalId = int.Parse(this.dataProtector.Unprotect(id));
            var users = GetUsers();
            var user = users.Where(x => x.Id == originalId).First();
            return Ok(user);
        }


        private List<UserModel> GetUsers()
        {
            var users = new List<UserModel>();
            users.Add(new UserModel() { Id = 1, Name = "TechInTalkUser" });
            return users;
        }
    }
}
