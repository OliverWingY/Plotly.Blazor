/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ScatterCarpetLib.UnselectedLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Marker 
    {
        /// <summary>
        ///     Sets the marker opacity of unselected points, applied only when a selection
        ///     exists.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets the marker color of unselected points, applied only when a selection
        ///     exists.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the marker size of unselected points, applied only when a selection
        ///     exists.
        /// </summary>
        [JsonPropertyName(@"size")]
        public float? Size { get; set;} 

    }
}