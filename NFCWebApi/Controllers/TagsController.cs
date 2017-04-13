using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NFCWebApi.Models;
using NFCWebApi.Static;

namespace NFCWebApi.Controllers {
    [Route("api/[controller]")]
    public class TagsController : Controller {

        [HttpGet("startup")]
        public string Get() {
            Global.FillTags();
            return "Welcome to the api";
        }

        [HttpGet]
        public IEnumerable<Tag> GetTags() {
            return Global.Tags;
        }

        [HttpGet("{tagId}")]
        public Tag GetTag(string tagId) {
            return this.GetSingleTag(tagId);
        }

        [HttpPost("register")]
        public void PostTag([FromBody] TagsModel tagModel) {
            var tag = this.GetSingleTag(tagModel.SerialId.ToUpper());
            tag.ToggleOccupation();
            var allTags = Global.Tags;
            var othertags = allTags.Where(t => t.SerialId != tag.SerialId).ToArray();
            foreach (Tag singleTag in othertags) {
                singleTag.DeOccupy();
            }
        }

        private Tag GetSingleTag(string tagId) {
            var tags = Global.Tags.Where(x => x.SerialId == tagId).ToArray();
            return tags.Length < 1 ? null : tags.First();
        }
    }
}