using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Entities;
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
    public class SelfBeliefController : ControllerBase
    {
        private readonly ISelfBeliefProvider selfBeliefProvider;

        public SelfBeliefController(ISelfBeliefProvider selfBeliefProvider)
        {
            this.selfBeliefProvider = selfBeliefProvider;
        }

        [HttpGet]
        [Route("{userId}")]
        public ActionResult GetUserPresets(Guid userId)
        {
            return Ok(new { status = 200, content = selfBeliefProvider.GetUserSelfBeliefs(userId) });
        }

        [HttpGet]
        [Route("help")]
        public ActionResult GetSelfBeliefsHelp()
        {
            return Ok(new { status = 200, content = selfBeliefProvider.GetSelfBeliefsHelp() });
        }

        [HttpPost]
        public ActionResult AddUserSelfBelief([FromBody] SelfBelief preset)
        {
            return Ok(new { status = 200, content = selfBeliefProvider.AddUserSelfBelief(preset).Result });
        }

        [HttpPatch]
        [Route("{noteId}")]
        public ActionResult UpdateUserPreset(Guid noteId, [FromBody] SelfBelief request)
        {
            return Ok(new { status = 200, content = selfBeliefProvider.UpdateUserSelfBelief(noteId, request).Result });
        }

        [HttpDelete]
        [Route("{noteId}")]
        public ActionResult DeleteUserPreset(Guid noteId)
        {
            return Ok(new { status = 200, content = selfBeliefProvider.DeleteUserSelfBelief (noteId).Result });
        }

        [HttpPost]
        [Route("{noteId}")]
        public ActionResult AddBeliefProof(Guid noteId, [FromBody] SelfBeliefProof proof)
        {
            return Ok(new { status = 200, content = selfBeliefProvider.AddBeliefProof(proof).Result });
        }
    }
}
