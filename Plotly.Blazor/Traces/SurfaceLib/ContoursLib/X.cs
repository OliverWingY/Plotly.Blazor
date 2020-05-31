/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.SurfaceLib.ContoursLib.XLib;

namespace Plotly.Blazor.Traces.SurfaceLib.ContoursLib
{
    /// <summary>
    ///     The X class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class X 
    {
        /// <summary>
        ///     Determines whether or not contour lines about the x dimension are drawn.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the starting contour level value. Must be less than `contours.end`
        /// </summary>
        [JsonPropertyName(@"start")]
        public float? Start { get; set;} 

        /// <summary>
        ///     Sets the end contour level value. Must be more than `contours.start`
        /// </summary>
        [JsonPropertyName(@"end")]
        public float? End { get; set;} 

        /// <summary>
        ///     Sets the step between each contour level. Must be positive.
        /// </summary>
        [JsonPropertyName(@"size")]
        public float? Size { get; set;} 

        /// <summary>
        ///     Gets or sets the Project.
        /// </summary>
        [JsonPropertyName(@"project")]
        public Plotly.Blazor.Traces.SurfaceLib.ContoursLib.XLib.Project Project { get; set;} 

        /// <summary>
        ///     Sets the color of the contour lines.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     An alternate to *color*. Determines whether or not the contour lines are
        ///     colored using the trace *colorscale*.
        /// </summary>
        [JsonPropertyName(@"usecolormap")]
        public bool? UseColorMap { get; set;} 

        /// <summary>
        ///     Sets the width of the contour lines.
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

        /// <summary>
        ///     Determines whether or not contour lines about the x dimension are highlighted
        ///     on hover.
        /// </summary>
        [JsonPropertyName(@"highlight")]
        public bool? Highlight { get; set;} 

        /// <summary>
        ///     Sets the color of the highlighted contour lines.
        /// </summary>
        [JsonPropertyName(@"highlightcolor")]
        public object HighlightColor { get; set;} 

        /// <summary>
        ///     Sets the width of the highlighted contour lines.
        /// </summary>
        [JsonPropertyName(@"highlightwidth")]
        public float? HighlightWidth { get; set;} 

    }
}