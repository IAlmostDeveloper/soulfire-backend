using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OpinionController : ControllerBase
    {
        private readonly IOpinionProvider opinionProvider;

        public OpinionController(IOpinionProvider opinionProvider)
        {
            this.opinionProvider = opinionProvider;
        }

        [HttpGet]
        [Route("thoughtswritingforms")]
        public ActionResult GetThoughtsWritingForms()
        {
            return Ok(new { status = 200, content = opinionProvider.GetThoughtsWritingForms() });
        }

        [HttpGet]
        [Route("thoughtssimpleforms")]
        public ActionResult GetThoughtsSimpleForms()
        {
            return Ok(new { status = 200, content = opinionProvider.GetThoughtsSimpleForms() });
        }

        [HttpGet]
        [Route("middleopinions")]
        public ActionResult GetMiddleOpinions()
        {
            return Ok(new { status = 200, content = opinionProvider.GetMiddleOpinions() });
        }

        [HttpGet]
        [Route("deepopinions")]
        public ActionResult GetDeepOpinions()
        {
            return Ok(new { status = 200, content = opinionProvider.GetDeepOpinions()});
        }
    }
}
