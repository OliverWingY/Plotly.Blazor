/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.MapBoxLib
{
    /// <summary>
    ///     The Layer class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Layer 
    {
        /// <summary>
        ///     Determines whether this layer is displayed
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the source type for this layer, that is the type of the layer data.
        /// </summary>
        [JsonPropertyName(@"sourcetype")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.SourceTypeEnum? SourceType { get; set;} 

        /// <summary>
        ///     Sets the source data for this layer (mapbox.layer.source). When <c>sourcetype</c>
        ///     is set to <c>geojson</c>, <c>source</c> can be a URL to a GeoJSON or a GeoJSON
        ///     object. When <c>sourcetype</c> is set to <c>vector</c> or <c>raster</c>,
        ///     <c>source</c> can be a URL or an array of tile URLs. When <c>sourcetype</c>
        ///     is set to <c>image</c>, <c>source</c> can be a URL to an image.
        /// </summary>
        [JsonPropertyName(@"source")]
        public object Source { get; set;} 

        /// <summary>
        ///     Specifies the layer to use from a vector tile source (mapbox.layer.source-layer).
        ///     Required for <c>vector</c> source type that supports multiple layers.
        /// </summary>
        [JsonPropertyName(@"sourcelayer")]
        public string SourceLayer { get; set;} 

        /// <summary>
        ///     Sets the attribution for this source.
        /// </summary>
        [JsonPropertyName(@"sourceattribution")]
        public string SourceAttribution { get; set;} 

        /// <summary>
        ///     Sets the layer type, that is the how the layer data set in <c>source</c>
        ///     will be rendered With <c>sourcetype</c> set to <c>geojson</c>, the following
        ///     values are allowed: <c>circle</c>, <c>line</c>, <c>fill</c> and <c>symbol</c>.
        ///     but note that <c>line</c> and <c>fill</c> are not compatible with Point
        ///     GeoJSON geometries. With <c>sourcetype</c> set to <c>vector</c>, the following
        ///     values are allowed:  <c>circle</c>, <c>line</c>, <c>fill</c> and <c>symbol</c>.
        ///     With <c>sourcetype</c> set to <c>raster</c> or <c><c>image</c></c>, only
        ///     the <c>raster</c> value is allowed.
        /// </summary>
        [JsonPropertyName(@"type")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Sets the coordinates array contains [longitude, latitude] pairs for the
        ///     image corners listed in clockwise order: top left, top right, bottom right,
        ///     bottom left. Only has an effect for <c>image</c> <c>sourcetype</c>.
        /// </summary>
        [JsonPropertyName(@"coordinates")]
        public object Coordinates { get; set;} 

        /// <summary>
        ///     Determines if the layer will be inserted before the layer with the specified
        ///     ID. If omitted or set to &#39;&#39;, the layer will be inserted above every
        ///     existing layer.
        /// </summary>
        [JsonPropertyName(@"below")]
        public string Below { get; set;} 

        /// <summary>
        ///     Sets the primary layer color. If <c>type</c> is <c>circle</c>, color corresponds
        ///     to the circle color (mapbox.layer.paint.circle-color) If <c>type</c> is
        ///     <c>line</c>, color corresponds to the line color (mapbox.layer.paint.line-color)
        ///     If <c>type</c> is <c>fill</c>, color corresponds to the fill color (mapbox.layer.paint.fill-color)
        ///     If <c>type</c> is <c>symbol</c>, color corresponds to the icon color (mapbox.layer.paint.icon-color)
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the opacity of the layer. If <c>type</c> is <c>circle</c>, opacity
        ///     corresponds to the circle opacity (mapbox.layer.paint.circle-opacity) If
        ///     <c>type</c> is <c>line</c>, opacity corresponds to the line opacity (mapbox.layer.paint.line-opacity)
        ///     If <c>type</c> is <c>fill</c>, opacity corresponds to the fill opacity (mapbox.layer.paint.fill-opacity)
        ///     If <c>type</c> is <c>symbol</c>, opacity corresponds to the icon/text opacity
        ///     (mapbox.layer.paint.text-opacity)
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets the minimum zoom level (mapbox.layer.minzoom). At zoom levels less
        ///     than the minzoom, the layer will be hidden.
        /// </summary>
        [JsonPropertyName(@"minzoom")]
        public float? MinZoom { get; set;} 

        /// <summary>
        ///     Sets the maximum zoom level (mapbox.layer.maxzoom). At zoom levels equal
        ///     to or greater than the maxzoom, the layer will be hidden.
        /// </summary>
        [JsonPropertyName(@"maxzoom")]
        public float? MaxZoom { get; set;} 

        /// <summary>
        ///     Gets or sets the Circle.
        /// </summary>
        [JsonPropertyName(@"circle")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.Circle Circle { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.Line Line { get; set;} 

        /// <summary>
        ///     Gets or sets the Fill.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.Fill Fill { get; set;} 

        /// <summary>
        ///     Gets or sets the Symbol.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public Plotly.Blazor.LayoutLib.MapBoxLib.LayerLib.Symbol Symbol { get; set;} 

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with <c>templateitemname</c>
        ///     matching this <c>name</c> alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). Has no effect outside
        ///     of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with <c>templateitemname</c>
        ///     matching its <c>name</c>, alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). If there is no template
        ///     or no matching item, this item will be hidden unless you explicitly show
        ///     it with &#39;visible: true&#39;.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set;} 

    }
}