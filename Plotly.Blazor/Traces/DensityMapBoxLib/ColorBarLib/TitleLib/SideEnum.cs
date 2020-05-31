/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.DensityMapBoxLib.ColorBarLib.TitleLib
{
    /// <summary>
    ///     Determines the location of color bar&#39;s title with respect to the color
    ///     bar. Note that the title&#39;s location used to be set by the now deprecated
    ///     <c>titleside</c> attribute.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value=@"top")]
        Top = 0,
        [EnumMember(Value=@"right")]
        Right,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}