using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class PresetsProvider : IPresetsProvider
    {
        private readonly Context context;

        public PresetsProvider(Context context)
        {
            this.context = context;
        }
        public async Task<Preset> AddUserPreset(Preset preset)
        {
            preset.Id = new Guid();
            context.Presets.Add(preset);
            await context.SaveChangesAsync();

            return preset;
        }

        public async Task<Preset> DeleteUserPreset(Guid presetId)
        {
            var pr = context.Presets.FirstOrDefault(x => x.Id == presetId);
            context.Presets.Remove(pr);
            await context.SaveChangesAsync();
            return pr;
        }

        public IEnumerable<Preset> GetAllPresets()
        {
            return context.Presets;
        }

        public IEnumerable<Preset> GetUserPresets(Guid userId)
        {
            return context.Presets.Where(x => x.UserId == userId).OrderByDescending(x => x.UpdatedDate);
        }

        public async Task<Preset> UpdateUserPreset(Guid presetId, Preset preset)
        {
            var pr = context.Presets.FirstOrDefault(x => x.Id == presetId);
            pr.Title = preset.Title;
            pr.Content = preset.Content;
            await context.SaveChangesAsync();
            return pr;
        }
    }
}
