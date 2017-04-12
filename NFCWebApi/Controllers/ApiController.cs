using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NFCWebApi.Static;

namespace NFCWebApi.Controllers {
    [Route("[controller]")]
    public class ApiController : Controller {

        [HttpGet]
        public string Get() {
            Global.FillTags();
            return "Welcome to the api";
        }

        [HttpGet("tags")]
        public IEnumerable<Tag> GetTags() {
            return Global.Tags;
        }

        [HttpGet("tags/{tagId}")]
        public Tag GetTag(string tagId) {
            return this.GetSingleTag(tagId);
        }

        [HttpPost("register")]
        public void PostTag([FromBody] string tagId) {
            var tag = this.GetSingleTag(tagId.ToUpper());
            tag.ToggleOccupation();
        }

        private Tag GetSingleTag(string tagId) {
            var tags = Global.Tags.Where(x => x.SerialId == tagId).ToArray();
            return tags.Length < 1 ? null : tags.First();
        }
    }
}