﻿using PSC.Blazor.Components.Chartjs.Enums;
using PSC.Blazor.Components.Chartjs.Models.Bar;
using System.Text.Json.Serialization;

namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Options
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Gets or sets the scales.
        /// </summary>
        /// <value>
        /// The scales.
        /// </value>
        [JsonPropertyName("scales")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Scales Scales { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Options"/> is responsive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if responsive; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("responsive")]
        public bool Responsive { get; set; } = true;
        /// <summary>
        /// Gets or sets a value indicating whether [maintain aspect ratio].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [maintain aspect ratio]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("maintainAspectRatio")]
        public bool MaintainAspectRatio { get; set; } = false;
        /// <summary>
        /// Gets or sets the plugins.
        /// </summary>
        /// <value>
        /// The plugins.
        /// </value>
        [JsonPropertyName("plugins")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Plugins Plugins { get; set; } = new Plugins();
        /// <summary>
        /// Gets or sets the index axis. <seealso cref="Axes"/>
        /// </summary>
        /// <value>
        /// X or Y
        /// </value>
        [JsonPropertyName("indexAxis")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string IndexAxis { get; set; } = Axes.Default;
    }
}