/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.IndicatorLib.TitleLib
{
    /// <summary>
    ///     Sets the horizontal alignment of the title. It defaults to <c>center</c>
    ///     except for bullet charts for which it defaults to right.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum AlignEnum
    {
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}