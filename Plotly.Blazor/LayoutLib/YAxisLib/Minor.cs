/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.YAxisLib
{
    /// <summary>
    ///     The Minor class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Serializable]
    public class Minor : IEquatable<Minor>
    {
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
        ///     Sets the color of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridcolor")]
        public object GridColor { get; set;} 

        /// <summary>
        ///     Sets the dash style of lines. Set to a dash type string (<c>solid</c>, <c>dot</c>,
        ///     <c>dash</c>, <c>longdash</c>, <c>dashdot</c>, or <c>longdashdot</c>) or
        ///     a dash length list in px (eg <c>5px,10px,2px,2px</c>).
        /// </summary>
        [JsonPropertyName(@"griddash")]
        public string GridDash { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public decimal? GridWidth { get; set;} 

        /// <summary>
        ///     Specifies the maximum number of ticks for the particular axis. The actual
        ///     number of ticks will be chosen automatically to be less than or equal to
        ///     <c>nticks</c>. Has an effect only if <c>tickmode</c> is set to <c>auto</c>.
        /// </summary>
        [JsonPropertyName(@"nticks")]
        public int? NTicks { get; set;} 

        /// <summary>
        ///     Determines whether or not grid lines are drawn. If <c>true</c>, the grid
        ///     lines are drawn at every tick mark.
        /// </summary>
        [JsonPropertyName(@"showgrid")]
        public bool? ShowGrid { get; set;} 

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
        ///     Sets the tick color.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object TickColor { get; set;} 

        /// <summary>
        ///     Sets the tick length (in px).
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public decimal? TickLen { get; set;} 

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
        public Plotly.Blazor.LayoutLib.YAxisLib.MinorLib.TickModeEnum? TickMode { get; set;} 

        /// <summary>
        ///     Determines whether ticks are drawn or not. If **, this axis&#39; ticks are
        ///     not drawn. If <c>outside</c> (<c>inside</c>), this axis&#39; are drawn outside
        ///     (inside) the axis lines.
        /// </summary>
        [JsonPropertyName(@"ticks")]
        public Plotly.Blazor.LayoutLib.YAxisLib.MinorLib.TicksEnum? Ticks { get; set;} 

        /// <summary>
        ///     Sets the values at which ticks on this axis appear. Only has an effect if
        ///     <c>tickmode</c> is set to <c>array</c>. Used with <c>ticktext</c>.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public IList<object> TickVals { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>tickvals</c>.
        /// </summary>
        [JsonPropertyName(@"tickvalssrc")]
        public string TickValsSrc { get; set;} 

        /// <summary>
        ///     Sets the tick width (in px).
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public decimal? TickWidth { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Minor other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Minor other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DTick == other.DTick ||
                    DTick != null &&
                    DTick.Equals(other.DTick)
                ) && 
                (
                    GridColor == other.GridColor ||
                    GridColor != null &&
                    GridColor.Equals(other.GridColor)
                ) && 
                (
                    GridDash == other.GridDash ||
                    GridDash != null &&
                    GridDash.Equals(other.GridDash)
                ) && 
                (
                    GridWidth == other.GridWidth ||
                    GridWidth != null &&
                    GridWidth.Equals(other.GridWidth)
                ) && 
                (
                    NTicks == other.NTicks ||
                    NTicks != null &&
                    NTicks.Equals(other.NTicks)
                ) && 
                (
                    ShowGrid == other.ShowGrid ||
                    ShowGrid != null &&
                    ShowGrid.Equals(other.ShowGrid)
                ) && 
                (
                    Tick0 == other.Tick0 ||
                    Tick0 != null &&
                    Tick0.Equals(other.Tick0)
                ) && 
                (
                    TickColor == other.TickColor ||
                    TickColor != null &&
                    TickColor.Equals(other.TickColor)
                ) && 
                (
                    TickLen == other.TickLen ||
                    TickLen != null &&
                    TickLen.Equals(other.TickLen)
                ) && 
                (
                    TickMode == other.TickMode ||
                    TickMode != null &&
                    TickMode.Equals(other.TickMode)
                ) && 
                (
                    Ticks == other.Ticks ||
                    Ticks != null &&
                    Ticks.Equals(other.Ticks)
                ) && 
                (
                    Equals(TickVals, other.TickVals) ||
                    TickVals != null && other.TickVals != null &&
                    TickVals.SequenceEqual(other.TickVals)
                ) &&
                (
                    TickValsSrc == other.TickValsSrc ||
                    TickValsSrc != null &&
                    TickValsSrc.Equals(other.TickValsSrc)
                ) && 
                (
                    TickWidth == other.TickWidth ||
                    TickWidth != null &&
                    TickWidth.Equals(other.TickWidth)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (DTick != null) hashCode = hashCode * 59 + DTick.GetHashCode();
                if (GridColor != null) hashCode = hashCode * 59 + GridColor.GetHashCode();
                if (GridDash != null) hashCode = hashCode * 59 + GridDash.GetHashCode();
                if (GridWidth != null) hashCode = hashCode * 59 + GridWidth.GetHashCode();
                if (NTicks != null) hashCode = hashCode * 59 + NTicks.GetHashCode();
                if (ShowGrid != null) hashCode = hashCode * 59 + ShowGrid.GetHashCode();
                if (Tick0 != null) hashCode = hashCode * 59 + Tick0.GetHashCode();
                if (TickColor != null) hashCode = hashCode * 59 + TickColor.GetHashCode();
                if (TickLen != null) hashCode = hashCode * 59 + TickLen.GetHashCode();
                if (TickMode != null) hashCode = hashCode * 59 + TickMode.GetHashCode();
                if (Ticks != null) hashCode = hashCode * 59 + Ticks.GetHashCode();
                if (TickVals != null) hashCode = hashCode * 59 + TickVals.GetHashCode();
                if (TickValsSrc != null) hashCode = hashCode * 59 + TickValsSrc.GetHashCode();
                if (TickWidth != null) hashCode = hashCode * 59 + TickWidth.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Minor and the right Minor.
        /// </summary>
        /// <param name="left">Left Minor.</param>
        /// <param name="right">Right Minor.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Minor left, Minor right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Minor and the right Minor.
        /// </summary>
        /// <param name="left">Left Minor.</param>
        /// <param name="right">Right Minor.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Minor left, Minor right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Minor</returns>
        public Minor DeepClone()
        {
            return this.Copy();
        }
    }
}