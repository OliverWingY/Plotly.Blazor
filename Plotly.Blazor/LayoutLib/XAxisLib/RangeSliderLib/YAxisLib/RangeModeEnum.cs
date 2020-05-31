/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.XAxisLib.RangeSliderLib.YAxisLib
{
    /// <summary>
    ///     Determines whether or not the range of this axis in the rangeslider use
    ///     the same value than in the main plot when zooming in/out. If *auto*, the
    ///     autorange will be used. If *fixed*, the `range` is used. If *match*, the
    ///     current range of the corresponding y-axis on the main subplot is used.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum RangeModeEnum
    {
        [EnumMember(Value=@"match")]
        Match = 0,
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"fixed")]
        Fixed
    }
}