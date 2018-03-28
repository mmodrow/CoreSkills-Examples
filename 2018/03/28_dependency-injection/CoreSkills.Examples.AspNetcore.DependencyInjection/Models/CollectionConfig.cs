// <copyright file="CollectionConfig.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using System.Collections.Generic;
using System.Linq;

namespace CoreSkills.Examples.AspNetcore.DependencyInjection.Models
{
    /// <summary>
    /// A configuration consisting of collection types.
    /// </summary>
    /// <seealso cref="CoreSkills.Examples.AspNetcore.DependencyInjection.Models.BaseConfig" />
    public class CollectionConfig : BaseConfig
    {
        /// <summary>
        /// Gets or sets the dictionary.
        /// </summary>
        /// <value>
        /// The dictionary.
        /// </value>
        public Dictionary<string, string> Dict { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets the array.
        /// </summary>
        /// <value>
        /// The array.
        /// </value>
        public int[] Array { get; set; } = new int[0];

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Dict: " + string.Join("; ", Dict.Select(pair => pair.Key + " => " + pair.Value)) + " || "
                + "Array: [" + string.Join(",", Array) + "]";
        }
    }
}