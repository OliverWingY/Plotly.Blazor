/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.IsoSurfaceLib.CapsLib
{
    /// <summary>
    ///     The Z class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Z 
    {
        /// <summary>
        ///     Sets the fill ratio of the <c>slices</c>. The default fill value of the
        ///     z <c>slices</c> is 1 meaning that they are entirely shaded. On the other
        ///     hand Applying a <c>fill</c> ratio less than one would allow the creation
        ///     of openings parallel to the edges.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the fill ratio of the <c>caps</c>. The default fill value of the <c>caps</c>
        ///     is 1 meaning that they are entirely shaded. On the other hand Applying a
        ///     <c>fill</c> ratio less than one would allow the creation of openings parallel
        ///     to the edges.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public float? Fill { get; set;} 

    }
}