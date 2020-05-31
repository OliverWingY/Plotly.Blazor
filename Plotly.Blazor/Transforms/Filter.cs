/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Transforms
{
    /// <summary>
    ///     The Filter class.
    ///     Implements the <see cref="ITransform" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Filter : ITransform
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TransformTypeEnum Type { get; } = TransformTypeEnum.Filter;

        /// <summary>
        ///     Determines whether this filter transform is enabled or disabled.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

        /// <summary>
        ///     Sets the filter target by which the filter is applied. If a string, <c>target</c>
        ///     is assumed to be a reference to a data array in the parent trace object.
        ///     To filter about nested variables, use <c>.</c> to access them. For example,
        ///     set <c>target</c> to <c>marker.color</c> to filter about the marker color
        ///     array. If an array, <c>target</c> is then the data array by which the filter
        ///     is applied.
        /// </summary>
        [JsonPropertyName(@"target")]
        public string Target { get; set;} 

        /// <summary>
        ///     Sets the filter operation. <c>=</c> keeps items equal to <c>value</c> <c>!=</c>
        ///     keeps items not equal to <c>value</c> <c>&lt;</c> keeps items less than
        ///     <c>value</c> <c>&lt;=</c> keeps items less than or equal to <c>value</c>
        ///     <c>&gt;</c> keeps items greater than <c>value</c> <c>&gt;=</c> keeps items
        ///     greater than or equal to <c>value</c> <c>[]</c> keeps items inside <c>value[0]</c>
        ///     to <c>value[1]</c> including both bounds <c>()</c> keeps items inside <c>value[0]</c>
        ///     to <c>value[1]</c> excluding both bounds <c>[)</c> keeps items inside <c>value[0]</c>
        ///     to <c>value[1]</c> including <c>value[0]</c> but excluding &#39;value[1]
        ///     <c>(]</c> keeps items inside <c>value[0]</c> to <c>value[1]</c> excluding
        ///     <c>value[0]</c> but including &#39;value[1] <c>][</c> keeps items outside
        ///     <c>value[0]</c> to <c>value[1]</c> and equal to both bounds <c>)(</c> keeps
        ///     items outside <c>value[0]</c> to <c>value[1]</c> <c>](</c> keeps items outside
        ///     <c>value[0]</c> to <c>value[1]</c> and equal to <c>value[0]</c> <c>)[</c>
        ///     keeps items outside <c>value[0]</c> to <c>value[1]</c> and equal to <c>value[1]</c>
        ///     <c>{}</c> keeps items present in a set of values <c>}{</c> keeps items not
        ///     present in a set of values
        /// </summary>
        [JsonPropertyName(@"operation")]
        public Plotly.Blazor.Transforms.FilterLib.OperationEnum? Operation { get; set;} 

        /// <summary>
        ///     Sets the value or values by which to filter. Values are expected to be in
        ///     the same type as the data linked to <c>target</c>. When <c>operation</c>
        ///     is set to one of the comparison values (=,!=,&lt;,&gt;=,&gt;,&lt;=) <c>value</c>
        ///     is expected to be a number or a string. When <c>operation</c> is set to
        ///     one of the interval values ([],(),[),(],][,)(,](,)[) <c>value</c> is expected
        ///     to be 2-item array where the first item is the lower bound and the second
        ///     item is the upper bound. When <c>operation</c>, is set to one of the set
        ///     values ({},}{) <c>value</c> is expected to be an array with as many items
        ///     as the desired set elements.
        /// </summary>
        [JsonPropertyName(@"value")]
        public object Value { get; set;} 

        /// <summary>
        ///     Determines whether or not gaps in data arrays produced by the filter operation
        ///     are preserved. Setting this to <c>true</c> might be useful when plotting
        ///     a line chart with <c>connectgaps</c> set to <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"preservegaps")]
        public bool? PreserveGaps { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use for <c>value</c>, if it is a date.
        /// </summary>
        [JsonPropertyName(@"valuecalendar")]
        public Plotly.Blazor.Transforms.FilterLib.ValueCalendarEnum? ValueCalendar { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use for <c>target</c>, if it is an array of
        ///     dates. If <c>target</c> is a string (eg <c>x</c>) we use the corresponding
        ///     trace attribute (eg <c>xcalendar</c>) if it exists, even if <c>targetcalendar</c>
        ///     is provided.
        /// </summary>
        [JsonPropertyName(@"targetcalendar")]
        public Plotly.Blazor.Transforms.FilterLib.TargetCalendarEnum? TargetCalendar { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  target .
        /// </summary>
        [JsonPropertyName(@"targetsrc")]
        public string TargetSrc { get; set;} 

    }
}