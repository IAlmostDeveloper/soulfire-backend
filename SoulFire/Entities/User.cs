﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SoulFire.Entities
{
    public class User
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [MaxLength(25)]
        public string Username { get; set; }
        public string Password { get; set; }

        public string CharacterType { get; set; }

        public List<UserAchievement>? Achievements { get; set; }
        public List<UserAutoThought>? AutoThoughts { get; set; }
        public List<UserMiddleThought>? MiddleThoughts { get; set; }
        public List<UserDeepThought>? DeepThoughts { get; set; }
    }
}
