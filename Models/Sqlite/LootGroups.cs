﻿namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class LootGroups
    {
        public long? Id { get; set; }
        public long? PackId { get; set; }
        public long? GroupNo { get; set; }
        public long? DropRate { get; set; }
        public long? ItemGradeDistributionId { get; set; }
    }
}
