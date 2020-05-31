/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.TreeMapLib.MarkerLib
{
    /// <summary>
    ///     Determines if the sector colors are faded towards the background from the
    ///     leaves up to the headers. This option is unavailable when a <c>colorscale</c>
    ///     is present, defaults to false when <c>marker.colors</c> is set, but otherwise
    ///     defaults to true. When set to <c>reversed</c>, the fading direction is inverted,
    ///     that is the top elements within hierarchy are drawn with fully saturated
    ///     colors while the leaves are faded towards the background color.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum DepthFadeEnum
    {
        [EnumMember(Value=@"True")]
        True,
        [EnumMember(Value=@"False")]
        False,
        [EnumMember(Value=@"reversed")]
        Reversed
    }
}