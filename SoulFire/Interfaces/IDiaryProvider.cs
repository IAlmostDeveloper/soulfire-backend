using SoulFire.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Interfaces
{
    public interface IDiaryProvider
    {
        IEnumerable<DiaryNote> GetUserDiaryNotes(Guid userId);
        Task<DiaryNote> AddDiaryNote(DiaryNote diaryNote);
        Task<DiaryNote> UpdateDiaryNote(Guid noteId, UpdateDiaryNoteRequest request);
        Task<DiaryNote> DeleteDiaryNote(Guid noteId);
    }
}
