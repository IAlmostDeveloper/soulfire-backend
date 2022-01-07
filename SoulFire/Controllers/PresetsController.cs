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
    public class PresetsController : ControllerBase
    {
        private readonly IPresetsProvider presetsProvider;
        public PresetsController(IPresetsProvider presetsProvider)
        {
            this.presetsProvider = presetsProvider;
        }

        [HttpGet]
        [Route("{userId}")]
        public ActionResult GetUserPresets(Guid userId)
        {
            return Ok(new { status = 200, content = presetsProvider.GetUserPresets(userId) });
        }

        [HttpPost]
        public ActionResult AddUserPreset([FromBody] Preset preset)
        {
            return Ok(new { status = 200, content = presetsProvider.AddUserPreset(preset).Result });
        }

        [HttpPatch]
        [Route("{noteId}")]
        public ActionResult UpdateUserPreset(Guid noteId, [FromBody] Preset request)
        {
            return Ok(new { status = 200, content = presetsProvider.UpdateUserPreset(noteId, request).Result });
        }

        [HttpDelete]
        [Route("{noteId}")]
        public ActionResult DeleteUserPreset(Guid noteId)
        {
            return Ok(new { status = 200, content = presetsProvider.DeleteUserPreset(noteId).Result });
        }
    }
}
