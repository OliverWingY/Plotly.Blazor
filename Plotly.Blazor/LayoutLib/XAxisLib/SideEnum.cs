/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.XAxisLib
{
    /// <summary>
    ///     Determines whether a x (y) axis is positioned at the <c>bottom</c> (<c>left</c>)
    ///     or <c>top</c> (<c>right</c>) of the plotting area.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"bottom")]
        Bottom,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"right")]
        Right
    }
}