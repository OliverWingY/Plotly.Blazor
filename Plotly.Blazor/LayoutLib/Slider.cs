/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.SliderLib;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Slider class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Slider 
    {
        /// <summary>
        ///     Determines whether or not the slider is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Determines which button (by index starting from 0) is considered active.
        /// </summary>
        [JsonPropertyName(@"active")]
        public float? Active { get; set;} 

        /// <summary>
        ///     Gets or sets the Steps.
        /// </summary>
        [JsonPropertyName(@"steps")]
        public IList<Plotly.Blazor.LayoutLib.SliderLib.Step> Steps { get; set;} 

        /// <summary>
        ///     Determines whether this slider length is set in units of plot *fraction*
        ///     or in *pixels. Use `len` to set the value.
        /// </summary>
        [JsonPropertyName(@"lenmode")]
        public Plotly.Blazor.LayoutLib.SliderLib.LenModeEnum? LenMode { get; set;} 

        /// <summary>
        ///     Sets the length of the slider This measure excludes the padding of both
        ///     ends. That is, the slider's length is this length minus the padding on both
        ///     ends.
        /// </summary>
        [JsonPropertyName(@"len")]
        public float? Len { get; set;} 

        /// <summary>
        ///     Sets the x position (in normalized coordinates) of the slider.
        /// </summary>
        [JsonPropertyName(@"x")]
        public float? X { get; set;} 

        /// <summary>
        ///     Set the padding of the slider component along each side.
        /// </summary>
        [JsonPropertyName(@"pad")]
        public Plotly.Blazor.LayoutLib.SliderLib.Pad Pad { get; set;} 

        /// <summary>
        ///     Sets the slider's horizontal position anchor. This anchor binds the `x`
        ///     position to the *left*, *center* or *right* of the range selector.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public Plotly.Blazor.LayoutLib.SliderLib.XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the y position (in normalized coordinates) of the slider.
        /// </summary>
        [JsonPropertyName(@"y")]
        public float? Y { get; set;} 

        /// <summary>
        ///     Sets the slider's vertical position anchor This anchor binds the `y` position
        ///     to the *top*, *middle* or *bottom* of the range selector.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public Plotly.Blazor.LayoutLib.SliderLib.YAnchorEnum? YAnchor { get; set;} 

        /// <summary>
        ///     Gets or sets the Transition.
        /// </summary>
        [JsonPropertyName(@"transition")]
        public Plotly.Blazor.LayoutLib.SliderLib.Transition Transition { get; set;} 

        /// <summary>
        ///     Gets or sets the CurrentValue.
        /// </summary>
        [JsonPropertyName(@"currentvalue")]
        public Plotly.Blazor.LayoutLib.SliderLib.CurrentValue CurrentValue { get; set;} 

        /// <summary>
        ///     Sets the font of the slider step labels.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.LayoutLib.SliderLib.Font Font { get; set;} 

        /// <summary>
        ///     Sets the background color of the slider grip while dragging.
        /// </summary>
        [JsonPropertyName(@"activebgcolor")]
        public object ActiveBgColor { get; set;} 

        /// <summary>
        ///     Sets the background color of the slider.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public float? BorderWidth { get; set;} 

        /// <summary>
        ///     Sets the length in pixels of step tick marks
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public float? TickleN { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object TickColor { get; set;} 

        /// <summary>
        ///     Sets the tick width (in px).
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public float? TickWidth { get; set;} 

        /// <summary>
        ///     Sets the length in pixels of minor step tick marks
        /// </summary>
        [JsonPropertyName(@"minorticklen")]
        public float? MinorTickLen { get; set;} 

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with `templateitemname`
        ///     matching this `name` alongside your modifications (including `visible: false`
        ///     or `enabled: false` to hide it). Has no effect outside of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with `templateitemname`
        ///     matching its `name`, alongside your modifications (including `visible: false`
        ///     or `enabled: false` to hide it). If there is no template or no matching
        ///     item, this item will be hidden unless you explicitly show it with `visible:
        ///     true`.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set;} 

    }
}