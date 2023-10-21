/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor
{
    /// <summary>
    ///     Determines the type of the trace.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TraceTypeEnum
    {
        [EnumMember(Value=@"bar")]
        Bar,
        [EnumMember(Value=@"barpolar")]
        BarPolar,
        [EnumMember(Value=@"box")]
        Box,
        [EnumMember(Value=@"candlestick")]
        Candlestick,
        [EnumMember(Value=@"carpet")]
        Carpet,
        [EnumMember(Value=@"choropleth")]
        Choropleth,
        [EnumMember(Value=@"choroplethmapbox")]
        ChoroplethMapBox,
        [EnumMember(Value=@"cone")]
        Cone,
        [EnumMember(Value=@"contour")]
        Contour,
        [EnumMember(Value=@"contourcarpet")]
        ContourCarpet,
        [EnumMember(Value=@"densitymapbox")]
        DensityMapBox,
        [EnumMember(Value=@"funnel")]
        Funnel,
        [EnumMember(Value=@"funnelarea")]
        FunnelArea,
        [EnumMember(Value=@"heatmap")]
        HeatMap,
        [EnumMember(Value=@"heatmapgl")]
        HeatMapGl,
        [EnumMember(Value=@"histogram")]
        Histogram,
        [EnumMember(Value=@"histogram2d")]
        Histogram2D,
        [EnumMember(Value=@"histogram2dcontour")]
        Histogram2DContour,
        [EnumMember(Value=@"icicle")]
        Icicle,
        [EnumMember(Value=@"image")]
        Image,
        [EnumMember(Value=@"indicator")]
        Indicator,
        [EnumMember(Value=@"isosurface")]
        IsoSurface,
        [EnumMember(Value=@"mesh3d")]
        Mesh3D,
        [EnumMember(Value=@"ohlc")]
        Ohlc,
        [EnumMember(Value=@"parcats")]
        ParCats,
        [EnumMember(Value=@"parcoords")]
        ParCoords,
        [EnumMember(Value=@"pie")]
        Pie,
        [EnumMember(Value=@"pointcloud")]
        PointCloud,
        [EnumMember(Value=@"sankey")]
        Sankey,
        [EnumMember(Value=@"scatter")]
        Scatter,
        [EnumMember(Value=@"scatter3d")]
        Scatter3D,
        [EnumMember(Value=@"scattercarpet")]
        ScatterCarpet,
        [EnumMember(Value=@"scattergeo")]
        ScatterGeo,
        [EnumMember(Value=@"scattergl")]
        ScatterGl,
        [EnumMember(Value=@"scattermapbox")]
        ScatterMapBox,
        [EnumMember(Value=@"scatterpolar")]
        ScatterPolar,
        [EnumMember(Value=@"scatterpolargl")]
        ScatterPolarGl,
        [EnumMember(Value=@"scattersmith")]
        ScatterSmith,
        [EnumMember(Value=@"scatterternary")]
        ScatterTernary,
        [EnumMember(Value=@"splom")]
        Splom,
        [EnumMember(Value=@"streamtube")]
        StreamTube,
        [EnumMember(Value=@"sunburst")]
        Sunburst,
        [EnumMember(Value=@"surface")]
        Surface,
        [EnumMember(Value=@"table")]
        Table,
        [EnumMember(Value=@"treemap")]
        TreeMap,
        [EnumMember(Value=@"violin")]
        Violin,
        [EnumMember(Value=@"volume")]
        Volume,
        [EnumMember(Value=@"waterfall")]
        Waterfall
    }
}