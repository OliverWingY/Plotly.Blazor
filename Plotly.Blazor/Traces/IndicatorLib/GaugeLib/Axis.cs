/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.IndicatorLib.GaugeLib
{
    /// <summary>
    ///     The Axis class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Axis 
    {
        /// <summary>
        ///     Sets the range of this axis.
        /// </summary>
        [JsonPropertyName(@"range")]
        public IList<object> Range { get; set;} 

        /// <summary>
        ///     A single toggle to hide the axis while preserving interaction like dragging.
        ///     Default is true when a cheater plot is present on the axis, otherwise false
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the tick mode for this axis. If <c>auto</c>, the number of ticks is
        ///     set via <c>nticks</c>. If <c>linear</c>, the placement of the ticks is determined
        ///     by a starting position <c>tick0</c> and a tick step <c>dtick</c> (<c>linear</c>
        ///     is the default value if <c>tick0</c> and <c>dtick</c> are provided). If
        ///     <c>array</c>, the placement of the ticks is set via <c>tickvals</c> and
        ///     the tick text is <c>ticktext</c>. (<c>array</c> is the default value if
        ///     <c>tickvals</c> is provided).
        /// </summary>
        [JsonPropertyName(@"tickmode")]
        public Plotly.Blazor.Traces.IndicatorLib.GaugeLib.AxisLib.TickModeEnum? TickMode { get; set;} 

        /// <summary>
        ///     Specifies the maximum number of ticks for the particular axis. The actual
        ///     number of ticks will be chosen automatically to be less than or equal to
        ///     <c>nticks</c>. Has an effect only if <c>tickmode</c> is set to <c>auto</c>.
        /// </summary>
        [JsonPropertyName(@"nticks")]
        public int? NTicks { get; set;} 

        /// <summary>
        ///     Sets the placement of the first tick on this axis. Use with <c>dtick</c>.
        ///     If the axis <c>type</c> is <c>log</c>, then you must take the log of your
        ///     starting tick (e.g. to set the starting tick to 100, set the <c>tick0</c>
        ///     to 2) except when <c>dtick</c>=<c>L&lt;f&gt;</c> (see <c>dtick</c> for more
        ///     info). If the axis <c>type</c> is <c>date</c>, it should be a date string,
        ///     like date data. If the axis <c>type</c> is <c>category</c>, it should be
        ///     a number, using the scale where each category is assigned a serial number
        ///     from zero in the order it appears.
        /// </summary>
        [JsonPropertyName(@"tick0")]
        public object Tick0 { get; set;} 

        /// <summary>
        ///     Sets the step in-between ticks on this axis. Use with <c>tick0</c>. Must
        ///     be a positive number, or special strings available to <c>log</c> and <c>date</c>
        ///     axes. If the axis <c>type</c> is <c>log</c>, then ticks are set every 10^(n*dtick)
        ///     where n is the tick number. For example, to set a tick mark at 1, 10, 100,
        ///     1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick
        ///     to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5),
        ///     or 0.69897000433. <c>log</c> has several special values; <c>L&lt;f&gt;</c>,
        ///     where <c>f</c> is a positive number, gives ticks linearly spaced in value
        ///     (but not position). For example <c>tick0</c> = 0.1, <c>dtick</c> = <c>L0.5</c>
        ///     will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small
        ///     digits between, use <c>D1</c> (all digits) or <c>D2</c> (only 2 and 5).
        ///     <c>tick0</c> is ignored for <c>D1</c> and <c>D2</c>. If the axis <c>type</c>
        ///     is <c>date</c>, then you must convert the time to milliseconds. For example,
        ///     to set the interval between ticks to one day, set <c>dtick</c> to 86400000.0.
        ///     <c>date</c> also has special values <c>M&lt;n&gt;</c> gives ticks spaced
        ///     by a number of months. <c>n</c> must be a positive integer. To set ticks
        ///     on the 15th of every third month, set <c>tick0</c> to <c>2000-01-15</c>
        ///     and <c>dtick</c> to <c>M3</c>. To set ticks every 4 years, set <c>dtick</c>
        ///     to <c>M48</c>
        /// </summary>
        [JsonPropertyName(@"dtick")]
        public object DTick { get; set;} 

        /// <summary>
        ///     Sets the values at which ticks on this axis appear. Only has an effect if
        ///     <c>tickmode</c> is set to <c>array</c>. Used with <c>ticktext</c>.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public IList<object> TickVals { get; set;} 

        /// <summary>
        ///     Sets the text displayed at the ticks position via <c>tickvals</c>. Only
        ///     has an effect if <c>tickmode</c> is set to <c>array</c>. Used with <c>tickvals</c>.
        /// </summary>
        [JsonPropertyName(@"ticktext")]
        public IList<object> TickText { get; set;} 

        /// <summary>
        ///     Determines whether ticks are drawn or not. If **, this axis&#39; ticks are
        ///     not drawn. If <c>outside</c> (<c>inside</c>), this axis&#39; are drawn outside
        ///     (inside) the axis lines.
        /// </summary>
        [JsonPropertyName(@"ticks")]
        public Plotly.Blazor.Traces.IndicatorLib.GaugeLib.AxisLib.TicksEnum? Ticks { get; set;} 

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
        ///     Sets the color bar&#39;s tick label font
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public Plotly.Blazor.Traces.IndicatorLib.GaugeLib.AxisLib.TickFont TickFont { get; set;} 

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the horizontal. For example,
        ///     a <c>tickangle</c> of -90 draws the tick labels vertically.
        /// </summary>
        [JsonPropertyName(@"tickangle")]
        public float? TickAngle { get; set;} 

        /// <summary>
        ///     Sets the tick label formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3&#39;s date formatter: <c>%{n}f</c> for fractional
        ///     seconds with n digits. For example, &#39;2016-10-13 09:15:23.456&#39; with
        ///     tickformat <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"tickformat")]
        public string TickFormat { get; set;} 

        /// <summary>
        ///     Gets or sets the TickFormatStops.
        /// </summary>
        [JsonPropertyName(@"tickformatstops")]
        public IList<Plotly.Blazor.Traces.IndicatorLib.GaugeLib.AxisLib.TickFormatStop> TickFormatStops { get; set;} 

        /// <summary>
        ///     Sets a tick label prefix.
        /// </summary>
        [JsonPropertyName(@"tickprefix")]
        public string TickPrefix { get; set;} 

        /// <summary>
        ///     If <c>all</c>, all tick labels are displayed with a prefix. If <c>first</c>,
        ///     only the first tick is displayed with a prefix. If <c>last</c>, only the
        ///     last tick is displayed with a suffix. If <c>none</c>, tick prefixes are
        ///     hidden.
        /// </summary>
        [JsonPropertyName(@"showtickprefix")]
        public Plotly.Blazor.Traces.IndicatorLib.GaugeLib.AxisLib.ShowTickPrefixEnum? ShowTickPrefix { get; set;} 

        /// <summary>
        ///     Sets a tick label suffix.
        /// </summary>
        [JsonPropertyName(@"ticksuffix")]
        public string TickSuffix { get; set;} 

        /// <summary>
        ///     Same as <c>showtickprefix</c> but for tick suffixes.
        /// </summary>
        [JsonPropertyName(@"showticksuffix")]
        public Plotly.Blazor.Traces.IndicatorLib.GaugeLib.AxisLib.ShowTickSuffixEnum? ShowTickSuffix { get; set;} 

        /// <summary>
        ///     If <c>true</c>, even 4-digit integers are separated
        /// </summary>
        [JsonPropertyName(@"separatethousands")]
        public bool? SeparateThousands { get; set;} 

        /// <summary>
        ///     Determines a formatting rule for the tick exponents. For example, consider
        ///     the number 1,000,000,000. If <c>none</c>, it appears as 1,000,000,000. If
        ///     <c>e</c>, 1e+9. If <c>E</c>, 1E+9. If <c>power</c>, 1x10^9 (with 9 in a
        ///     super script). If <c>SI</c>, 1G. If <c>B</c>, 1B.
        /// </summary>
        [JsonPropertyName(@"exponentformat")]
        public Plotly.Blazor.Traces.IndicatorLib.GaugeLib.AxisLib.ExponentFormatEnum? ExponentFormat { get; set;} 

        /// <summary>
        ///     If <c>all</c>, all exponents are shown besides their significands. If <c>first</c>,
        ///     only the exponent of the first tick is shown. If <c>last</c>, only the exponent
        ///     of the last tick is shown. If <c>none</c>, no exponents appear.
        /// </summary>
        [JsonPropertyName(@"showexponent")]
        public Plotly.Blazor.Traces.IndicatorLib.GaugeLib.AxisLib.ShowExponentEnum? ShowExponent { get; set;} 

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