using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class DiaryProvider : IDiaryProvider
    {
        private readonly Context context;

        public DiaryProvider(Context context)
        {
            this.context = context;
        }
        
        public async Task<DiaryNote> AddDiaryNote(DiaryNote diaryNote)
        {
            diaryNote.Id = new Guid();
            context.DiaryNotes.Add(diaryNote);
            await context.SaveChangesAsync();
            return diaryNote;
        }

        public async Task<DiaryNote> DeleteDiaryNote(Guid noteId)
        {
            var diaryNote = context.DiaryNotes.FirstOrDefault(x => x.Id == noteId);
            context.DiaryNotes.Remove(diaryNote);
            await context.SaveChangesAsync();

            return diaryNote;
        }

        public IEnumerable<DiaryNote> GetUserDiaryNotes(Guid userId)
        {
            return context.DiaryNotes.Where(x => x.UserId == userId).OrderByDescending(x => x.UpdatedDate);
        }

        public async Task<DiaryNote> UpdateDiaryNote(Guid noteId, UpdateDiaryNoteRequest request)
        {
            var diaryNote = context.DiaryNotes.FirstOrDefault(x => x.Id == noteId);
            diaryNote.Title = request.Title;
            diaryNote.Content = request.Content;

            await context.SaveChangesAsync();
            return diaryNote;
        }
    }
}
