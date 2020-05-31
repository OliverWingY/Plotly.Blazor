/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib;

namespace Plotly.Blazor.Traces.ScatterLib.MarkerLib
{
    /// <summary>
    ///     The ColorBar class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class ColorBar 
    {
        /// <summary>
        ///     Determines whether this color bar's thickness (i.e. the measure in the constant
        ///     color direction) is set in units of plot *fraction* or in *pixels*. Use
        ///     `thickness` to set the value.
        /// </summary>
        [JsonPropertyName(@"thicknessmode")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.ThicknessModeEnum? ThicknessMode { get; set;} 

        /// <summary>
        ///     Sets the thickness of the color bar This measure excludes the size of the
        ///     padding, ticks and labels.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public float? Thickness { get; set;} 

        /// <summary>
        ///     Determines whether this color bar's length (i.e. the measure in the color
        ///     variation direction) is set in units of plot *fraction* or in *pixels. Use
        ///     `len` to set the value.
        /// </summary>
        [JsonPropertyName(@"lenmode")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.LenModeEnum? LenMode { get; set;} 

        /// <summary>
        ///     Sets the length of the color bar This measure excludes the padding of both
        ///     ends. That is, the color bar length is this length minus the padding on
        ///     both ends.
        /// </summary>
        [JsonPropertyName(@"len")]
        public float? Len { get; set;} 

        /// <summary>
        ///     Sets the x position of the color bar (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"x")]
        public float? X { get; set;} 

        /// <summary>
        ///     Sets this color bar's horizontal position anchor. This anchor binds the
        ///     `x` position to the *left*, *center* or *right* of the color bar.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the amount of padding (in px) along the x direction.
        /// </summary>
        [JsonPropertyName(@"xpad")]
        public float? XPad { get; set;} 

        /// <summary>
        ///     Sets the y position of the color bar (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"y")]
        public float? Y { get; set;} 

        /// <summary>
        ///     Sets this color bar's vertical position anchor This anchor binds the `y`
        ///     position to the *top*, *middle* or *bottom* of the color bar.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.YAnchorEnum? YAnchor { get; set;} 

        /// <summary>
        ///     Sets the amount of padding (in px) along the y direction.
        /// </summary>
        [JsonPropertyName(@"ypad")]
        public float? YPad { get; set;} 

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"outlinecolor")]
        public object OutlineColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the axis line.
        /// </summary>
        [JsonPropertyName(@"outlinewidth")]
        public float? OutlineWidth { get; set;} 

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) or the border enclosing this color bar.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public float? BorderWidth { get; set;} 

        /// <summary>
        ///     Sets the color of padded area.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the tick mode for this axis. If *auto*, the number of ticks is set
        ///     via `nticks`. If *linear*, the placement of the ticks is determined by a
        ///     starting position `tick0` and a tick step `dtick` (*linear* is the default
        ///     value if `tick0` and `dtick` are provided). If *array*, the placement of
        ///     the ticks is set via `tickvals` and the tick text is `ticktext`. (*array*
        ///     is the default value if `tickvals` is provided).
        /// </summary>
        [JsonPropertyName(@"tickmode")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.TickModeEnum? TickMode { get; set;} 

        /// <summary>
        ///     Specifies the maximum number of ticks for the particular axis. The actual
        ///     number of ticks will be chosen automatically to be less than or equal to
        ///     `nticks`. Has an effect only if `tickmode` is set to *auto*.
        /// </summary>
        [JsonPropertyName(@"nticks")]
        public int? NTicks { get; set;} 

        /// <summary>
        ///     Sets the placement of the first tick on this axis. Use with `dtick`. If
        ///     the axis `type` is *log*, then you must take the log of your starting tick
        ///     (e.g. to set the starting tick to 100, set the `tick0` to 2) except when
        ///     `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*,
        ///     it should be a date string, like date data. If the axis `type` is *category*,
        ///     it should be a number, using the scale where each category is assigned a
        ///     serial number from zero in the order it appears.
        /// </summary>
        [JsonPropertyName(@"tick0")]
        public object Tick0 { get; set;} 

        /// <summary>
        ///     Sets the step in-between ticks on this axis. Use with `tick0`. Must be a
        ///     positive number, or special strings available to *log* and *date* axes.
        ///     If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where
        ///     n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000,
        ///     ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to
        ///     2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5),
        ///     or 0.69897000433. *log* has several special values; *L<f>*, where `f` is
        ///     a positive number, gives ticks linearly spaced in value (but not position).
        ///     For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6,
        ///     1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all
        ///     digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If
        ///     the axis `type` is *date*, then you must convert the time to milliseconds.
        ///     For example, to set the interval between ticks to one day, set `dtick` to
        ///     86400000.0. *date* also has special values *M<n>* gives ticks spaced by
        ///     a number of months. `n` must be a positive integer. To set ticks on the
        ///     15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*.
        ///     To set ticks every 4 years, set `dtick` to *M48*
        /// </summary>
        [JsonPropertyName(@"dtick")]
        public object DTick { get; set;} 

        /// <summary>
        ///     Sets the values at which ticks on this axis appear. Only has an effect if
        ///     `tickmode` is set to *array*. Used with `ticktext`.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public IList<object> TickVals { get; set;} 

        /// <summary>
        ///     Sets the text displayed at the ticks position via `tickvals`. Only has an
        ///     effect if `tickmode` is set to *array*. Used with `tickvals`.
        /// </summary>
        [JsonPropertyName(@"ticktext")]
        public IList<object> TickText { get; set;} 

        /// <summary>
        ///     Determines whether ticks are drawn or not. If **, this axis' ticks are not
        ///     drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the
        ///     axis lines.
        /// </summary>
        [JsonPropertyName(@"ticks")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.TicksEnum? Ticks { get; set;} 

        /// <summary>
        ///     Sets the tick length (in px).
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public float? TickleN { get; set;} 

        /// <summary>
        ///     Sets the tick width (in px).
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public float? TickWidth { get; set;} 

        /// <summary>
        ///     Sets the tick color.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object TickColor { get; set;} 

        /// <summary>
        ///     Determines whether or not the tick labels are drawn.
        /// </summary>
        [JsonPropertyName(@"showticklabels")]
        public bool? ShowTickLabels { get; set;} 

        /// <summary>
        ///     Sets the color bar's tick label font
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.TickFont TickFont { get; set;} 

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the horizontal. For example,
        ///     a `tickangle` of -90 draws the tick labels vertically.
        /// </summary>
        [JsonPropertyName(@"tickangle")]
        public float? TickAngle { get; set;} 

        /// <summary>
        ///     Sets the tick label formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3's date formatter: *%{n}f* for fractional seconds with
        ///     n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f*
        ///     would display *09~15~23.46*
        /// </summary>
        [JsonPropertyName(@"tickformat")]
        public string TickFormat { get; set;} 

        /// <summary>
        ///     Gets or sets the TickFormatStops.
        /// </summary>
        [JsonPropertyName(@"tickformatstops")]
        public IList<Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.TickFormatStop> TickFormatStops { get; set;} 

        /// <summary>
        ///     Sets a tick label prefix.
        /// </summary>
        [JsonPropertyName(@"tickprefix")]
        public string TickPrefix { get; set;} 

        /// <summary>
        ///     If *all*, all tick labels are displayed with a prefix. If *first*, only
        ///     the first tick is displayed with a prefix. If *last*, only the last tick
        ///     is displayed with a suffix. If *none*, tick prefixes are hidden.
        /// </summary>
        [JsonPropertyName(@"showtickprefix")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.ShowTickPrefixEnum? ShowTickPrefix { get; set;} 

        /// <summary>
        ///     Sets a tick label suffix.
        /// </summary>
        [JsonPropertyName(@"ticksuffix")]
        public string TickSuffix { get; set;} 

        /// <summary>
        ///     Same as `showtickprefix` but for tick suffixes.
        /// </summary>
        [JsonPropertyName(@"showticksuffix")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.ShowTickSuffixEnum? ShowTickSuffix { get; set;} 

        /// <summary>
        ///     If "true", even 4-digit integers are separated
        /// </summary>
        [JsonPropertyName(@"separatethousands")]
        public bool? SeparateThousands { get; set;} 

        /// <summary>
        ///     Determines a formatting rule for the tick exponents. For example, consider
        ///     the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*,
        ///     1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*,
        ///     1G. If *B*, 1B.
        /// </summary>
        [JsonPropertyName(@"exponentformat")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.ExponentFormatEnum? ExponentFormat { get; set;} 

        /// <summary>
        ///     If *all*, all exponents are shown besides their significands. If *first*,
        ///     only the exponent of the first tick is shown. If *last*, only the exponent
        ///     of the last tick is shown. If *none*, no exponents appear.
        /// </summary>
        [JsonPropertyName(@"showexponent")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.ShowExponentEnum? ShowExponent { get; set;} 

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Plotly.Blazor.Traces.ScatterLib.MarkerLib.ColorBarLib.Title Title { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  tickvals .
        /// </summary>
        [JsonPropertyName(@"tickvalssrc")]
        public string TickValsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ticktext .
        /// </summary>
        [JsonPropertyName(@"ticktextsrc")]
        public string TickTextSrc { get; set;} 

    }
}