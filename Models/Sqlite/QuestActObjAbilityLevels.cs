﻿namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjAbilityLevels
    {
        public long Id { get; set; }
        public long? AbilityId { get; set; }
        public long? Level { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }
    }
}
