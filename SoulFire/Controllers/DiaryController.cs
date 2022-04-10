using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Core.Entities;
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
    public class DiaryController : ControllerBase
    {
        private readonly IDiaryProvider diaryProvider;

        public DiaryController(IDiaryProvider opinionProvider)
        {
            diaryProvider = opinionProvider;
        }

        [HttpGet]
        [Route("{userId}")]
        public ActionResult GetUserDiaryNotes(Guid userId)
        {
            return Ok(new { status = 200, content = diaryProvider.GetUserDiaryNotes(userId) });
        }

        [HttpGet]
        [Route("help")]
        public ActionResult GetDiaryNotesHelp()
        {
            return Ok(new { status = 200, content = diaryProvider.GetDiaryNotesHelp() });
        }

        [HttpPost]
        public ActionResult AddDiaryNote([FromBody] DiaryNote diaryNote)
        {
            return Ok(new { status = 200, content = diaryProvider.AddDiaryNote(diaryNote).Result });
        }

        [HttpPatch]
        [Route("{noteId}")]
        public ActionResult UpdateDiaryNote(Guid noteId, [FromBody] UpdateDiaryNoteRequest request )
        {
            return Ok(new { status = 200, content = diaryProvider.UpdateDiaryNote(noteId, request).Result });
        }

        [HttpDelete]
        [Route("{noteId}")]
        public ActionResult DeleteDiaryNote(Guid noteId)
        {
            return Ok(new { status = 200, content = diaryProvider.DeleteDiaryNote(noteId).Result });
        }

    }
}
