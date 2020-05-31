/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.IsoSurfaceLib.SlicesLib
{
    /// <summary>
    ///     The X class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class X 
    {
        /// <summary>
        ///     Determines whether or not slice planes about the x dimension are drawn.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Specifies the location(s) of slices on the axis. When not specified slices
        ///     would be created for all points of the axis x except start and end.
        /// </summary>
        [JsonPropertyName(@"locations")]
        public IList<object> Locations { get; set;} 

        /// <summary>
        ///     Sets the fill ratio of the <c>slices</c>. The default fill value of the
        ///     <c>slices</c> is 1 meaning that they are entirely shaded. On the other hand
        ///     Applying a <c>fill</c> ratio less than one would allow the creation of openings
        ///     parallel to the edges.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public float? Fill { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  locations .
        /// </summary>
        [JsonPropertyName(@"locationssrc")]
        public string LocationsSrc { get; set;} 

    }
}