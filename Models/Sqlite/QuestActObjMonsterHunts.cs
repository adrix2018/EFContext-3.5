﻿namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjMonsterHunts
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? HighlightDoodadPhase { get; set; }
        public long? HighlightDoodadId { get; set; }
        public byte[] LongDist { get; set; }
        public long? NpcId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
