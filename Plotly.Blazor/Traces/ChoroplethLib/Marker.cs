/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ChoroplethLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Marker 
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.ChoroplethLib.MarkerLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets the opacity of the locations.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  opacity .
        /// </summary>
        [JsonPropertyName(@"opacitysrc")]
        public string OpacitySrc { get; set;} 

    }
}