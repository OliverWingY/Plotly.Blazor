/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.ContourLib.ColorBarLib
{
    /// <summary>
    ///     The TickFormatStop class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class TickFormatStop 
    {
        /// <summary>
        ///     Determines whether or not this stop is used. If <c>false</c>, this stop
        ///     is ignored even within its <c>dtickrange</c>.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

        /// <summary>
        ///     range [<c>min</c>, <c>max</c>], where <c>min</c>, <c>max</c> - dtick values
        ///     which describe some zoom level, it is possible to omit <c>min</c> or <c>max</c>
        ///     value by passing <c>null</c>
        /// </summary>
        [JsonPropertyName(@"dtickrange")]
        public IList<object> DTickRange { get; set;} 

        /// <summary>
        ///     string - dtickformat for described zoom level, the same as <c>tickformat</c>
        /// </summary>
        [JsonPropertyName(@"value")]
        public string Value { get; set;} 

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