/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ChoroplethLib.ColorBarLib
{
    /// <summary>
    ///     Determines where tick labels are drawn relative to the ticks. Left and right
    ///     options are used when <c>orientation</c> is <c>h</c>, top and bottom when
    ///     <c>orientation</c> is <c>v</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TickLabelPositionEnum
    {
        [EnumMember(Value=@"outside")]
        Outside = 0,
        [EnumMember(Value=@"inside")]
        Inside,
        [EnumMember(Value=@"outside top")]
        OutsideTop,
        [EnumMember(Value=@"inside top")]
        InsideTop,
        [EnumMember(Value=@"outside left")]
        OutsideLeft,
        [EnumMember(Value=@"inside left")]
        InsideLeft,
        [EnumMember(Value=@"outside right")]
        OutsideRight,
        [EnumMember(Value=@"inside right")]
        InsideRight,
        [EnumMember(Value=@"outside bottom")]
        OutsideBottom,
        [EnumMember(Value=@"inside bottom")]
        InsideBottom
    }
}