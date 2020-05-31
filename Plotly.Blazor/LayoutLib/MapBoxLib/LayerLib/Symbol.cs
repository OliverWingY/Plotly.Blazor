/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib
{
    /// <summary>
    ///     The Symbol class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Symbol 
    {
        /// <summary>
        ///     Sets the symbol icon image (mapbox.layer.layout.icon-image). Full list:
        ///     https://www.mapbox.com/maki-icons/
        /// </summary>
        [JsonPropertyName(@"icon")]
        public string Icon { get; set;} 

        /// <summary>
        ///     Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect
        ///     only when <c>type</c> is set to <c>symbol</c>.
        /// </summary>
        [JsonPropertyName(@"iconsize")]
        public float? IconSize { get; set;} 

        /// <summary>
        ///     Sets the symbol text (mapbox.layer.layout.text-field).
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement).
        ///     If <c>placement</c> is <c>point</c>, the label is placed where the geometry
        ///     is located If <c>placement</c> is <c>line</c>, the label is placed along
        ///     the line of the geometry If <c>placement</c> is <c>line-center</c>, the
        ///     label is placed on the center of the geometry
        /// </summary>
        [JsonPropertyName(@"placement")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.SymbolLib.PlacementEnum? Placement { get; set;} 

        /// <summary>
        ///     Sets the icon text font (color=mapbox.layer.paint.text-color, size=mapbox.layer.layout.text-size).
        ///     Has an effect only when <c>type</c> is set to <c>symbol</c>.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.SymbolLib.TextFont TextFont { get; set;} 

        /// <summary>
        ///     Sets the positions of the <c>text</c> elements with respects to the (x,y)
        ///     coordinates.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.SymbolLib.TextPositionEnum? TextPosition { get; set;} 

    }
}