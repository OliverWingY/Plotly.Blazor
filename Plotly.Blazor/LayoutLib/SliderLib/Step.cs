/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.LayoutLib.SliderLib
{
    /// <summary>
    ///     The Step class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Step 
    {
        /// <summary>
        ///     Determines whether or not this step is included in the slider.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the Plotly method to be called when the slider value is changed. If
        ///     the <c>skip</c> method is used, the API slider will function as normal but
        ///     will perform no API calls and will not bind automatically to state updates.
        ///     This may be used to create a component interface and attach to slider events
        ///     manually via JavaScript.
        /// </summary>
        [JsonPropertyName(@"method")]
        public Plotly.Blazor.LayoutLib.SliderLib.StepLib.MethodEnum? Method { get; set;} 

        /// <summary>
        ///     Sets the arguments values to be passed to the Plotly method set in <c>method</c>
        ///     on slide.
        /// </summary>
        [JsonPropertyName(@"args")]
        public IList<object> Args { get; set;} 

        /// <summary>
        ///     Sets the text label to appear on the slider
        /// </summary>
        [JsonPropertyName(@"label")]
        public string Label { get; set;} 

        /// <summary>
        ///     Sets the value of the slider step, used to refer to the step programatically.
        ///     Defaults to the slider label if not provided.
        /// </summary>
        [JsonPropertyName(@"value")]
        public string Value { get; set;} 

        /// <summary>
        ///     When true, the API method is executed. When false, all other behaviors are
        ///     the same and command execution is skipped. This may be useful when hooking
        ///     into, for example, the <c>plotly_sliderchange</c> method and executing the
        ///     API command manually without losing the benefit of the slider automatically
        ///     binding to the state of the plot through the specification of <c>method</c>
        ///     and <c>args</c>.
        /// </summary>
        [JsonPropertyName(@"execute")]
        public bool? Execute { get; set;} 

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