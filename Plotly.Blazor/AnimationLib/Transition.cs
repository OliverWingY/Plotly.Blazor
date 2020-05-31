/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.AnimationLib
{
    /// <summary>
    ///     The Transition class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Transition 
    {
        /// <summary>
        ///     The duration of the transition, in milliseconds. If equal to zero, updates
        ///     are synchronous.
        /// </summary>
        [JsonPropertyName(@"duration")]
        public float? Duration { get; set;} 

        /// <summary>
        ///     The easing function used for the transition
        /// </summary>
        [JsonPropertyName(@"easing")]
        public Plotly.Blazor.AnimationLib.TransitionLib.EasingEnum? Easing { get; set;} 

        /// <summary>
        ///     Determines whether the figure&#39;s layout or traces smoothly transitions
        ///     during updates that make both traces and layout change.
        /// </summary>
        [JsonPropertyName(@"ordering")]
        public Plotly.Blazor.AnimationLib.TransitionLib.OrderingEnum? Ordering { get; set;} 

    }
}