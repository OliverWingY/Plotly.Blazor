/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.ScatterTernaryLib.LineLib;

namespace Plotly.Blazor.Traces.ScatterTernaryLib
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Line 
    {
        /// <summary>
        ///     Sets the line color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the line width (in px).
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

        /// <summary>
        ///     Sets the dash style of lines. Set to a dash type string (*solid*, *dot*,
        ///     *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in
        ///     px (eg *5px,10px,2px,2px*).
        /// </summary>
        [JsonPropertyName(@"dash")]
        public string Dash { get; set;} 

        /// <summary>
        ///     Determines the line shape. With *spline* the lines are drawn using spline
        ///     interpolation. The other available values correspond to step-wise line shapes.
        /// </summary>
        [JsonPropertyName(@"shape")]
        public Plotly.Blazor.Traces.ScatterTernaryLib.LineLib.ShapeEnum? Shape { get; set;} 

        /// <summary>
        ///     Has an effect only if `shape` is set to *spline* Sets the amount of smoothing.
        ///     *0* corresponds to no smoothing (equivalent to a *linear* shape).
        /// </summary>
        [JsonPropertyName(@"smoothing")]
        public float? Smoothing { get; set;} 

    }
}