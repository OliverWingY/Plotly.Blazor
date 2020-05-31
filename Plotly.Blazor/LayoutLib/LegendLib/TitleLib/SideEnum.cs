/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.LegendLib.TitleLib
{
    /// <summary>
    ///     Determines the location of legend&#39;s title with respect to the legend
    ///     items. Defaulted to *top* with `orientation` is *h*. Defaulted to *left*
    ///     with `orientation` is *v*. The *top left* options could be used to expand
    ///     legend area in both x and y sides.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"top left")]
        TopLeft
    }
}