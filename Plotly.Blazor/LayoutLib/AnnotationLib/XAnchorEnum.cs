/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.AnnotationLib
{
    /// <summary>
    ///     Sets the text box&#39;s horizontal position anchor This anchor binds the
    ///     <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c> of the
    ///     annotation. For example, if <c>x</c> is set to 1, <c>xref</c> to <c>paper</c>
    ///     and <c>xanchor</c> to <c>right</c> then the right-most portion of the annotation
    ///     lines up with the right-most edge of the plotting area. If <c>auto</c>,
    ///     the anchor is equivalent to <c>center</c> for data-referenced annotations
    ///     or if there is an arrow, whereas for paper-referenced with no arrow, the
    ///     anchor picked corresponds to the closest side.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value=@"auto")]
        Auto = 0,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}