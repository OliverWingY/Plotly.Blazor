/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.HeatMapLib.ColorBarLib
{
    /// <summary>
    ///     Sets this color bar&#39;s horizontal position anchor. This anchor binds
    ///     the <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c>
    ///     of the color bar.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value=@"left")]
        Left = 0,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}