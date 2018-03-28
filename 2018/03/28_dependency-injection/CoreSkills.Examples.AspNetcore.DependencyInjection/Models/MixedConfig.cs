// <copyright file="MixedConfig.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using System;
using System.Globalization;

namespace CoreSkills.Examples.AspNetcore.DependencyInjection.Models
{
    /// <summary>
    /// A configuration of mixed types.
    /// </summary>
    /// <seealso cref="CoreSkills.Examples.AspNetcore.DependencyInjection.Models.BaseConfig" />
    public class MixedConfig : BaseConfig
    {
        /// <summary>
        /// Gets or sets some number.
        /// </summary>
        /// <value>
        /// Some number.
        /// </value>
        public int SomeNumber { get; set; }

        /// <summary>
        /// Gets or sets the serious string.
        /// </summary>
        /// <value>
        /// The serious string.
        /// </value>
        public string SeriousString { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is hilarious.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is hilarious; otherwise, <c>false</c>.
        /// </value>
        public bool IsHilarious { get; set; }

        /// <summary>
        /// Gets or sets the unreferenced time.
        /// </summary>
        /// <value>
        /// The unreferenced time.
        /// </value>
        public DateTime UnreferencedTime { get; set; } = DateTime.MinValue;

        /// <inheritdoc />
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "SomeNumber: " + SomeNumber + " || SeriousString: " + SeriousString + " || IsHilarous: " +
                   IsHilarious + " || UnreferencedTime: " + UnreferencedTime.ToString(CultureInfo.InvariantCulture);
        }
    }
}