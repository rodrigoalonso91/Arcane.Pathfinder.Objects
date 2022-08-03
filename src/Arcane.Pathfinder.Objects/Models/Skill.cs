﻿using Arcane.Pathfinder.Objects.Abstractions;

namespace Arcane.Pathfinder.Objects.Models
{
    public class Skill : ISkill
    {
        public string SkillName { get; set; } = string.Empty;
        public bool IsClassSkill { get; set; }
        public int Ranks { get; set; }
        public bool HasArmorPenalty { get; set; }

        public Skill()
        {

        }
    }
}