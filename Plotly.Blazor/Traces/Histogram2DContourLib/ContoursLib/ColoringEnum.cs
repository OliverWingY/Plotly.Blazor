/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.Histogram2DContourLib.ContoursLib
{
    /// <summary>
    ///     Determines the coloring method showing the contour values. If *fill*, coloring
    ///     is done evenly between each contour level If *heatmap*, a heatmap gradient
    ///     coloring is applied between each contour level. If *lines*, coloring is
    ///     done on the contour lines. If *none*, no coloring is applied on this trace.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ColoringEnum
    {
        [EnumMember(Value=@"fill")]
        Fill = 0,
        [EnumMember(Value=@"heatmap")]
        HeatMap,
        [EnumMember(Value=@"lines")]
        Lines,
        [EnumMember(Value=@"none")]
        None
    }
}