/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.SymbolLib
{
    /// <summary>
    ///     Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement).
    ///     If <c>placement</c> is <c>point</c>, the label is placed where the geometry
    ///     is located If <c>placement</c> is <c>line</c>, the label is placed along
    ///     the line of the geometry If <c>placement</c> is <c>line-center</c>, the
    ///     label is placed on the center of the geometry
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum PlacementEnum
    {
        [EnumMember(Value=@"point")]
        Point = 0,
        [EnumMember(Value=@"line")]
        Line,
        [EnumMember(Value=@"line-center")]
        LineCenter
    }
}