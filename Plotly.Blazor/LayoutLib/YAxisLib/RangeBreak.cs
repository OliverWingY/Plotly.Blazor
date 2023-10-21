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
    ///     The RangeBreak class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Serializable]
    public class RangeBreak : IEquatable<RangeBreak>
    {
        /// <summary>
        ///     Sets the lower and upper bounds of this axis rangebreak. Can be used with
        ///     <c>pattern</c>.
        /// </summary>
        [JsonPropertyName(@"bounds")]
        public IList<object> Bounds { get; set;} 

        /// <summary>
        ///     Sets the size of each <c>values</c> item. The default is one day in milliseconds.
        /// </summary>
        [JsonPropertyName(@"dvalue")]
        public decimal? DValue { get; set;} 

        /// <summary>
        ///     Determines whether this axis rangebreak is enabled or disabled. Please note
        ///     that <c>rangebreaks</c> only work for <c>date</c> axis type.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

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
        ///     Determines a pattern on the time line that generates breaks. If &#39;day
        ///     of week&#39; - days of the week in English e.g. <c>Sunday</c> or <c>sun</c>
        ///     (matching is case-insensitive and considers only the first three characters),
        ///     as well as Sunday-based integers between 0 and 6. If <c>hour</c> - hour
        ///     (24-hour clock) as decimal numbers between 0 and 24. for more info. Examples:
        ///     - { pattern: &#39;day of week&#39;, bounds: [6, 1] }  or simply { bounds:
        ///     [<c>sat</c>, <c>mon</c>] }   breaks from Saturday to Monday (i.e. skips
        ///     the weekends). - { pattern: <c>hour</c>, bounds: [17, 8] }   breaks from
        ///     5pm to 8am (i.e. skips non-work hours).
        /// </summary>
        [JsonPropertyName(@"pattern")]
        public Plotly.Blazor.LayoutLib.YAxisLib.RangeBreakLib.PatternEnum? Pattern { get; set;} 

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

        /// <summary>
        ///     Sets the coordinate values corresponding to the rangebreaks. An alternative
        ///     to <c>bounds</c>. Use <c>dvalue</c> to set the size of the values along
        ///     the axis.
        /// </summary>
        [JsonPropertyName(@"values")]
        public IList<object> Values { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is RangeBreak other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] RangeBreak other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Equals(Bounds, other.Bounds) ||
                    Bounds != null && other.Bounds != null &&
                    Bounds.SequenceEqual(other.Bounds)
                ) &&
                (
                    DValue == other.DValue ||
                    DValue != null &&
                    DValue.Equals(other.DValue)
                ) && 
                (
                    Enabled == other.Enabled ||
                    Enabled != null &&
                    Enabled.Equals(other.Enabled)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Pattern == other.Pattern ||
                    Pattern != null &&
                    Pattern.Equals(other.Pattern)
                ) && 
                (
                    TemplateItemName == other.TemplateItemName ||
                    TemplateItemName != null &&
                    TemplateItemName.Equals(other.TemplateItemName)
                ) && 
                (
                    Equals(Values, other.Values) ||
                    Values != null && other.Values != null &&
                    Values.SequenceEqual(other.Values)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Bounds != null) hashCode = hashCode * 59 + Bounds.GetHashCode();
                if (DValue != null) hashCode = hashCode * 59 + DValue.GetHashCode();
                if (Enabled != null) hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (Pattern != null) hashCode = hashCode * 59 + Pattern.GetHashCode();
                if (TemplateItemName != null) hashCode = hashCode * 59 + TemplateItemName.GetHashCode();
                if (Values != null) hashCode = hashCode * 59 + Values.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left RangeBreak and the right RangeBreak.
        /// </summary>
        /// <param name="left">Left RangeBreak.</param>
        /// <param name="right">Right RangeBreak.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (RangeBreak left, RangeBreak right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left RangeBreak and the right RangeBreak.
        /// </summary>
        /// <param name="left">Left RangeBreak.</param>
        /// <param name="right">Right RangeBreak.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (RangeBreak left, RangeBreak right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>RangeBreak</returns>
        public RangeBreak DeepClone()
        {
            return this.Copy();
        }
    }
}