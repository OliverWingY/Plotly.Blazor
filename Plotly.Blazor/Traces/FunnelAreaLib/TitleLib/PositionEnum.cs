/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.FunnelAreaLib.TitleLib
{
    /// <summary>
    ///     Specifies the location of the <c>title</c>. Note that the title&#39;s position
    ///     used to be set by the now deprecated <c>titleposition</c> attribute.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum PositionEnum
    {
        [EnumMember(Value=@"top center")]
        TopCenter = 0,
        [EnumMember(Value=@"top left")]
        TopLeft,
        [EnumMember(Value=@"top right")]
        TopRight
    }
}