using SoulFire.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Interfaces
{
    public interface IPresetsProvider
    {
        IEnumerable<Preset> GetUserPresets(Guid userId);
        Task<Preset> AddUserPreset(Preset preset);
        Task<Preset> UpdateUserPreset(Guid presetId, Preset preset);
        Task<Preset> DeleteUserPreset(Guid presetId);
    }
}
