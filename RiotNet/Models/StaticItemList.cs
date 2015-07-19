﻿using System;
using System.Collections.Generic;

namespace RiotNet.Models
{
    /// <summary>
    /// Contains item list data.
    /// </summary>
    public class StaticItemList : StaticDataList
    {
        /// <summary>
        /// Creates a new <see cref="StaticItemList"/> instance.
        /// </summary>
        public StaticItemList()
        {
            Type = "item";
        }

        /// <summary>
        /// Gets or sets the basic item data, which contains the default value for each Item property.
        /// </summary>
        public StaticItem Basic { get; set; }

        /// <summary>
        /// Gets or sets the set of items indexed by name.
        /// </summary>
        public Dictionary<string, StaticItem> Data { get; set; }

        /// <summary>
        /// Gets or sets the list of groups, which define the maximum number of items of certain types that a player can own.
        /// </summary>
        public List<Group> Groups { get; set; }

        /// <summary>
        /// Gets or sets the item tree data.
        /// </summary>
        public List<StaticItemTree> Tree { get; set; }
    }
}