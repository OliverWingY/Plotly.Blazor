/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.Histogram2DContourLib;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The Histogram2DContour class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Histogram2DContour : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum Type { get; } = TraceTypeEnum.Histogram2DContour;

        /// <summary>
        ///     Determines whether or not this trace is visible. If *legendonly*, the trace
        ///     is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set;} 

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public IList<object> Ids { get; set;} 

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, *scatter* traces also appends customdata
        ///     items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace `name`, graph, axis
        ///     and colorbar `title.text`, annotation `text` `rangeselector`, `updatemenues`
        ///     and `sliders` `label` text all support `meta`. To access the trace `meta`
        ///     values in an attribute in the same trace, simply use `%{meta[i]}` where
        ///     `i` is the index or key of the `meta` item in question. To access trace
        ///     `meta` in layout attributes, use `%{data[n[.meta[i]}` where `i` is the index
        ///     or key of the `meta` and `n` is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object Meta { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If `none` or `skip`
        ///     are set, no information is displayed upon hovering. But, if `none` is set,
        ///     click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.Stream Stream { get; set;} 

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        [JsonConverter(typeof(PolymorphicConverter))]
        public ITransform Transforms { get; set;} 

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: `constraintrange`
        ///     in `parcoords` traces, as well as some `editable: true` modifications such
        ///     as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that
        ///     other user-driven trace attribute changes are controlled by `layout` attributes:
        ///     `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints`
        ///     is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible
        ///     with `config: {editable: true}`) is controlled by `layout.editrevision`.
        ///     Trace changes are tracked by `uid`, which only falls back on trace index
        ///     if no `uid` is provided. So if your app can add/remove traces before the
        ///     end of the `data` array, such that the same trace has a different index,
        ///     you can still preserve user-driven changes if you give each trace a `uid`
        ///     that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Sets the sample data to be binned on the x axis.
        /// </summary>
        [JsonPropertyName(@"x")]
        public IList<object> X { get; set;} 

        /// <summary>
        ///     Sets the sample data to be binned on the y axis.
        /// </summary>
        [JsonPropertyName(@"y")]
        public IList<object> Y { get; set;} 

        /// <summary>
        ///     Sets the aggregation data.
        /// </summary>
        [JsonPropertyName(@"z")]
        public IList<object> Z { get; set;} 

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.Marker Marker { get; set;} 

        /// <summary>
        ///     Specifies the type of normalization used for this histogram trace. If **,
        ///     the span of each bar corresponds to the number of occurrences (i.e. the
        ///     number of data points lying inside the bins). If *percent* / *probability*,
        ///     the span of each bar corresponds to the percentage / fraction of occurrences
        ///     with respect to the total number of sample points (here, the sum of all
        ///     bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds
        ///     to the number of occurrences in a bin divided by the size of the bin interval
        ///     (here, the sum of all bin AREAS equals the total number of sample points).
        ///     If *probability density*, the area of each bar corresponds to the probability
        ///     that an event will fall into the corresponding bin (here, the sum of all
        ///     bin AREAS equals 1).
        /// </summary>
        [JsonPropertyName(@"histnorm")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.HistNormEnum? HistNorm { get; set;} 

        /// <summary>
        ///     Specifies the binning function used for this histogram trace. If *count*,
        ///     the histogram values are computed by counting the number of values lying
        ///     inside each bin. If *sum*, *avg*, *min*, *max*, the histogram values are
        ///     computed using the sum, the average, the minimum or the maximum of the values
        ///     lying inside each bin respectively.
        /// </summary>
        [JsonPropertyName(@"histfunc")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.HistFuncEnum? HistFunc { get; set;} 

        /// <summary>
        ///     Specifies the maximum number of desired bins. This value will be used in
        ///     an algorithm that will decide the optimal bin size such that the histogram
        ///     best visualizes the distribution of the data. Ignored if `xbins.size` is
        ///     provided.
        /// </summary>
        [JsonPropertyName(@"nbinsx")]
        public int? NBinsX { get; set;} 

        /// <summary>
        ///     Gets or sets the XBins.
        /// </summary>
        [JsonPropertyName(@"xbins")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.XBins XBins { get; set;} 

        /// <summary>
        ///     Specifies the maximum number of desired bins. This value will be used in
        ///     an algorithm that will decide the optimal bin size such that the histogram
        ///     best visualizes the distribution of the data. Ignored if `ybins.size` is
        ///     provided.
        /// </summary>
        [JsonPropertyName(@"nbinsy")]
        public int? NBinsY { get; set;} 

        /// <summary>
        ///     Gets or sets the YBins.
        /// </summary>
        [JsonPropertyName(@"ybins")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.YBins YBins { get; set;} 

        /// <summary>
        ///     Obsolete: since v1.42 each bin attribute is auto-determined separately and
        ///     `autobinx` is not needed. However, we accept `autobinx: true` or `false`
        ///     and will update `xbins` accordingly before deleting `autobinx` from the
        ///     trace.
        /// </summary>
        [JsonPropertyName(@"autobinx")]
        public bool? AutoBinX { get; set;} 

        /// <summary>
        ///     Obsolete: since v1.42 each bin attribute is auto-determined separately and
        ///     `autobiny` is not needed. However, we accept `autobiny: true` or `false`
        ///     and will update `ybins` accordingly before deleting `autobiny` from the
        ///     trace.
        /// </summary>
        [JsonPropertyName(@"autobiny")]
        public bool? AutoBinY { get; set;} 

        /// <summary>
        ///     Set the `xbingroup` and `ybingroup` default prefix For example, setting
        ///     a `bingroup` of *1* on two histogram2d traces will make them their x-bins
        ///     and y-bins match separately.
        /// </summary>
        [JsonPropertyName(@"bingroup")]
        public string BinGroup { get; set;} 

        /// <summary>
        ///     Set a group of histogram traces which will have compatible x-bin settings.
        ///     Using `xbingroup`, histogram2d and histogram2dcontour traces  (on axes of
        ///     the same axis type) can have compatible x-bin settings. Note that the same
        ///     `xbingroup` value can be used to set (1D) histogram `bingroup`
        /// </summary>
        [JsonPropertyName(@"xbingroup")]
        public string XBinGroup { get; set;} 

        /// <summary>
        ///     Set a group of histogram traces which will have compatible y-bin settings.
        ///     Using `ybingroup`, histogram2d and histogram2dcontour traces  (on axes of
        ///     the same axis type) can have compatible y-bin settings. Note that the same
        ///     `ybingroup` value can be used to set (1D) histogram `bingroup`
        /// </summary>
        [JsonPropertyName(@"ybingroup")]
        public string YBinGroup { get; set;} 

        /// <summary>
        ///     Determines whether or not the contour level attributes are picked by an
        ///     algorithm. If *true*, the number of contour levels can be set in `ncontours`.
        ///     If *false*, set the contour level attributes in `contours`.
        /// </summary>
        [JsonPropertyName(@"autocontour")]
        public bool? AutoContour { get; set;} 

        /// <summary>
        ///     Sets the maximum number of contour levels. The actual number of contours
        ///     will be chosen automatically to be less than or equal to the value of `ncontours`.
        ///     Has an effect only if `autocontour` is *true* or if `contours.size` is missing.
        /// </summary>
        [JsonPropertyName(@"ncontours")]
        public int? NContours { get; set;} 

        /// <summary>
        ///     Gets or sets the Contours.
        /// </summary>
        [JsonPropertyName(@"contours")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.Contours Contours { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets the hover text formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        /// </summary>
        [JsonPropertyName(@"zhoverformat")]
        public string ZHoverFormat { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override `hoverinfo`. Variables are inserted using
        ///     %{variable}, for example "y: %{y}". Numbers are formatted using d3-format's
        ///     syntax %{variable:d3-format}, for example "Price: %{y:$.2f}". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format's
        ///     syntax %{variable|d3-time-format}, for example "Day: %{2019-01-01|%A}".
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in `hovertemplate`
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are `arrayOk: true`) are available. variable `z` Anything contained
        ///     in tag `<extra>` is displayed in the secondary box, for example "<extra>{fullData.name}</extra>".
        ///     To hide the secondary box completely, use an empty tag `<extra></extra>`.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults
        ///     to `false` when `zmin` and `zmax` are set by the user.
        /// </summary>
        [JsonPropertyName(@"zauto")]
        public bool? ZAuto { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as in `z` and if set, `zmax` must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmin")]
        public float? ZMin { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as in `z` and if set, `zmin` must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmax")]
        public float? ZMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to
        ///     be equidistant to this point. Value should have the same units as in `z`.
        ///     Has no effect when `zauto` is `false`.
        /// </summary>
        [JsonPropertyName(@"zmid")]
        public float? ZMid { get; set;} 

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the
        ///     bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively,
        ///     `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (`autocolorscale:
        ///     true`) or the palette determined by `colorscale`. In case `colorscale` is
        ///     unspecified or `autocolorscale` is true, the default  palette will be chosen
        ///     according to whether numbers in the `color` array are all positive, all
        ///     negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. If true, `zmin` will correspond to the
        ///     last color in the array and `zmax` will correspond to the first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these
        ///     shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`,
        ///     etc. Note that multiple color scales can be linked to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use with `x` date data.
        /// </summary>
        [JsonPropertyName(@"xcalendar")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.XCalendarEnum? XCalendar { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use with `y` date data.
        /// </summary>
        [JsonPropertyName(@"ycalendar")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.YCalendarEnum? YCalendar { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace's x coordinates and a 2D cartesian x
        ///     axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`.
        ///     If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string XAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace's y coordinates and a 2D cartesian y
        ///     axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`.
        ///     If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string YAxis { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ids .
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

    }
}