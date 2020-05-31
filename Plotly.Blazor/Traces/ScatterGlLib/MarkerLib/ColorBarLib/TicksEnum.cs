/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterGlLib.MarkerLib.ColorBarLib
{
    /// <summary>
    ///     Determines whether ticks are drawn or not. If **, this axis&#39; ticks are
    ///     not drawn. If *outside* (*inside*), this axis&#39; are drawn outside (inside)
    ///     the axis lines.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TicksEnum
    {
        [EnumMember(Value=@"")]
        Empty = 0,
        [EnumMember(Value=@"outside")]
        Outside,
        [EnumMember(Value=@"inside")]
        Inside
    }
}