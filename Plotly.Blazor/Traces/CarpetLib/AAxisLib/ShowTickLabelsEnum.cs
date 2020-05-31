/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.CarpetLib.AAxisLib
{
    /// <summary>
    ///     Determines whether axis labels are drawn on the low side, the high side,
    ///     both, or neither side of the axis.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowTickLabelsEnum
    {
        [EnumMember(Value=@"start")]
        Start = 0,
        [EnumMember(Value=@"end")]
        End,
        [EnumMember(Value=@"both")]
        Both,
        [EnumMember(Value=@"none")]
        None
    }
}