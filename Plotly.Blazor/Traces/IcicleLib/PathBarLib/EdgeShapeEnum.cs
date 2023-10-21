/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.IcicleLib.PathBarLib
{
    /// <summary>
    ///     Determines which shape is used for edges between <c>barpath</c> labels.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum EdgeShapeEnum
    {
        [EnumMember(Value=@">")]
        GreaterThan = 0,
        [EnumMember(Value=@"<")]
        LessThan,
        [EnumMember(Value=@"|")]
        VerticalBar,
        [EnumMember(Value=@"/")]
        Slash,
        [EnumMember(Value=@"\")]
        Backslash
    }
}