/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.GeoLib.ProjectionLib
{
    /// <summary>
    ///     The Rotation class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Rotation 
    {
        /// <summary>
        ///     Rotates the map along parallels (in degrees East). Defaults to the center
        ///     of the <c>lonaxis.range</c> values.
        /// </summary>
        [JsonPropertyName(@"lon")]
        public float? Lon { get; set;} 

        /// <summary>
        ///     Rotates the map along meridians (in degrees North).
        /// </summary>
        [JsonPropertyName(@"lat")]
        public float? Lat { get; set;} 

        /// <summary>
        ///     Roll the map (in degrees) For example, a roll of <c>180</c> makes the map
        ///     appear upside down.
        /// </summary>
        [JsonPropertyName(@"roll")]
        public float? Roll { get; set;} 

    }
}