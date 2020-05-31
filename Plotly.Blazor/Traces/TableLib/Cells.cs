/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.TableLib
{
    /// <summary>
    ///     The Cells class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Cells 
    {
        /// <summary>
        ///     Cell values. <c>values[m][n]</c> represents the value of the <c>n</c>th
        ///     point in column <c>m</c>, therefore the <c>values[m]</c> vector length for
        ///     all columns must be the same (longer vectors will be truncated). Each value
        ///     must be a finite number or a string.
        /// </summary>
        [JsonPropertyName(@"values")]
        public IList<object> Values { get; set;} 

        /// <summary>
        ///     Sets the cell value formatting rule using d3 formatting mini-language which
        ///     is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        /// </summary>
        [JsonPropertyName(@"format")]
        public IList<object> Format { get; set;} 

        /// <summary>
        ///     Prefix for cell values.
        /// </summary>
        [JsonPropertyName(@"prefix")]
        public string Prefix { get; set;} 

        /// <summary>
        ///     Suffix for cell values.
        /// </summary>
        [JsonPropertyName(@"suffix")]
        public string Suffix { get; set;} 

        /// <summary>
        ///     The height of cells.
        /// </summary>
        [JsonPropertyName(@"height")]
        public float? Height { get; set;} 

        /// <summary>
        ///     Sets the horizontal alignment of the <c>text</c> within the box. Has an
        ///     effect only if <c>text</c> spans two or more lines (i.e. <c>text</c> contains
        ///     one or more &lt;br&gt; HTML tags) or if an explicit width is set to override
        ///     the text width.
        /// </summary>
        [JsonPropertyName(@"align")]
        public Plotly.Blazor.Traces.TableLib.CellsLib.AlignEnum? Align { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.TableLib.CellsLib.Line Line { get; set;} 

        /// <summary>
        ///     Gets or sets the Fill.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public Plotly.Blazor.Traces.TableLib.CellsLib.Fill Fill { get; set;} 

        /// <summary>
        ///     Gets or sets the Font.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.Traces.TableLib.CellsLib.Font Font { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  values .
        /// </summary>
        [JsonPropertyName(@"valuessrc")]
        public string ValuesSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  format .
        /// </summary>
        [JsonPropertyName(@"formatsrc")]
        public string FormatSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  prefix .
        /// </summary>
        [JsonPropertyName(@"prefixsrc")]
        public string PrefixSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  suffix .
        /// </summary>
        [JsonPropertyName(@"suffixsrc")]
        public string SuffixSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  align .
        /// </summary>
        [JsonPropertyName(@"alignsrc")]
        public string AlignSrc { get; set;} 

    }
}