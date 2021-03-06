﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace RiotNet.Models
{
    /// <summary>
    /// Contains information about a banned champion.
    /// </summary>
    public class BannedChampion
    {
        /// <summary>
        /// Gets or sets the banned champion id (see StaticChampion Id).
        /// </summary>
        public long ChampionId { get; set; }

        /// <summary>
        /// Gets or sets the turn during which the champion was banned.
        /// </summary>
        public int PickTurn { get; set; }

        private TeamSide? teamId;

        /// <summary>
        /// Gets or sets the team that banned the champion.
        /// </summary>
        public TeamSide TeamId
        {
            get { return teamId ?? (PickTurn % 2 == 1 ? TeamSide.Team1 : TeamSide.Team2); }
            set { teamId = value; }
        }

#if DB_READY
        /// <summary>
        /// Gets or sets the ID of the <see cref="BannedChampion"/>. This does NOT come from the Riot API; it is used as a key when storing this object in a database.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public long DatabaseId { get; set; }
#endif
    }
}
