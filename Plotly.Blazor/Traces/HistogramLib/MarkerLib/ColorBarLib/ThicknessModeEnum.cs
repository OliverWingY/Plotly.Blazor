/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.HistogramLib.MarkerLib.ColorBarLib
{
    /// <summary>
    ///     Determines whether this color bar&#39;s thickness (i.e. the measure in the
    ///     constant color direction) is set in units of plot *fraction* or in *pixels*.
    ///     Use `thickness` to set the value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ThicknessModeEnum
    {
        [EnumMember(Value=@"pixels")]
        Pixels = 0,
        [EnumMember(Value=@"fraction")]
        Fraction
    }
}