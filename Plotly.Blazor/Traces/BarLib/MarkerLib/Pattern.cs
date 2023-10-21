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

namespace Plotly.Blazor.Traces.BarLib.MarkerLib
{
    /// <summary>
    ///     The Pattern class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Pattern : IEquatable<Pattern>
    {
        /// <summary>
        ///     When there is no colorscale sets the color of background pattern fill. Defaults
        ///     to a <c>marker.color</c> background when <c>fillmode</c> is <c>overlay</c>.
        ///     Otherwise, defaults to a transparent background.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     When there is no colorscale sets the color of background pattern fill. Defaults
        ///     to a <c>marker.color</c> background when <c>fillmode</c> is <c>overlay</c>.
        ///     Otherwise, defaults to a transparent background.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        [Array]
        public IList<object> BgColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>bgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"bgcolorsrc")]
        public string BgColorSrc { get; set;} 

        /// <summary>
        ///     When there is no colorscale sets the color of foreground pattern fill. Defaults
        ///     to a <c>marker.color</c> background when <c>fillmode</c> is <c>replace</c>.
        ///     Otherwise, defaults to dark grey or white to increase contrast with the
        ///     <c>bgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"fgcolor")]
        public object FgColor { get; set;} 

        /// <summary>
        ///     When there is no colorscale sets the color of foreground pattern fill. Defaults
        ///     to a <c>marker.color</c> background when <c>fillmode</c> is <c>replace</c>.
        ///     Otherwise, defaults to dark grey or white to increase contrast with the
        ///     <c>bgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"fgcolor")]
        [Array]
        public IList<object> FgColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>fgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"fgcolorsrc")]
        public string FgColorSrc { get; set;} 

        /// <summary>
        ///     Sets the opacity of the foreground pattern fill. Defaults to a 0.5 when
        ///     <c>fillmode</c> is <c>overlay</c>. Otherwise, defaults to 1.
        /// </summary>
        [JsonPropertyName(@"fgopacity")]
        public decimal? FgOpacity { get; set;} 

        /// <summary>
        ///     Determines whether <c>marker.color</c> should be used as a default to <c>bgcolor</c>
        ///     or a <c>fgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"fillmode")]
        public Plotly.Blazor.Traces.BarLib.MarkerLib.PatternLib.FillModeEnum? FillMode { get; set;} 

        /// <summary>
        ///     Sets the shape of the pattern fill. By default, no pattern is used for filling
        ///     the area.
        /// </summary>
        [JsonPropertyName(@"shape")]
        public Plotly.Blazor.Traces.BarLib.MarkerLib.PatternLib.ShapeEnum? Shape { get; set;} 

        /// <summary>
        ///     Sets the shape of the pattern fill. By default, no pattern is used for filling
        ///     the area.
        /// </summary>
        [JsonPropertyName(@"shape")]
        [Array]
        public IList<Plotly.Blazor.Traces.BarLib.MarkerLib.PatternLib.ShapeEnum?> ShapeArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>shape</c>.
        /// </summary>
        [JsonPropertyName(@"shapesrc")]
        public string ShapeSrc { get; set;} 

        /// <summary>
        ///     Sets the size of unit squares of the pattern fill in pixels, which corresponds
        ///     to the interval of repetition of the pattern.
        /// </summary>
        [JsonPropertyName(@"size")]
        public decimal? Size { get; set;} 

        /// <summary>
        ///     Sets the size of unit squares of the pattern fill in pixels, which corresponds
        ///     to the interval of repetition of the pattern.
        /// </summary>
        [JsonPropertyName(@"size")]
        [Array]
        public IList<decimal?> SizeArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>size</c>.
        /// </summary>
        [JsonPropertyName(@"sizesrc")]
        public string SizeSrc { get; set;} 

        /// <summary>
        ///     Sets the solidity of the pattern fill. Solidity is roughly the fraction
        ///     of the area filled by the pattern. Solidity of 0 shows only the background
        ///     color without pattern and solidty of 1 shows only the foreground color without
        ///     pattern.
        /// </summary>
        [JsonPropertyName(@"solidity")]
        public decimal? Solidity { get; set;} 

        /// <summary>
        ///     Sets the solidity of the pattern fill. Solidity is roughly the fraction
        ///     of the area filled by the pattern. Solidity of 0 shows only the background
        ///     color without pattern and solidty of 1 shows only the foreground color without
        ///     pattern.
        /// </summary>
        [JsonPropertyName(@"solidity")]
        [Array]
        public IList<decimal?> SolidityArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>solidity</c>.
        /// </summary>
        [JsonPropertyName(@"soliditysrc")]
        public string SoliditySrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Pattern other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Pattern other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    Equals(BgColorArray, other.BgColorArray) ||
                    BgColorArray != null && other.BgColorArray != null &&
                    BgColorArray.SequenceEqual(other.BgColorArray)
                ) &&
                (
                    BgColorSrc == other.BgColorSrc ||
                    BgColorSrc != null &&
                    BgColorSrc.Equals(other.BgColorSrc)
                ) && 
                (
                    FgColor == other.FgColor ||
                    FgColor != null &&
                    FgColor.Equals(other.FgColor)
                ) && 
                (
                    Equals(FgColorArray, other.FgColorArray) ||
                    FgColorArray != null && other.FgColorArray != null &&
                    FgColorArray.SequenceEqual(other.FgColorArray)
                ) &&
                (
                    FgColorSrc == other.FgColorSrc ||
                    FgColorSrc != null &&
                    FgColorSrc.Equals(other.FgColorSrc)
                ) && 
                (
                    FgOpacity == other.FgOpacity ||
                    FgOpacity != null &&
                    FgOpacity.Equals(other.FgOpacity)
                ) && 
                (
                    FillMode == other.FillMode ||
                    FillMode != null &&
                    FillMode.Equals(other.FillMode)
                ) && 
                (
                    Shape == other.Shape ||
                    Shape != null &&
                    Shape.Equals(other.Shape)
                ) && 
                (
                    Equals(ShapeArray, other.ShapeArray) ||
                    ShapeArray != null && other.ShapeArray != null &&
                    ShapeArray.SequenceEqual(other.ShapeArray)
                ) &&
                (
                    ShapeSrc == other.ShapeSrc ||
                    ShapeSrc != null &&
                    ShapeSrc.Equals(other.ShapeSrc)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    Equals(SizeArray, other.SizeArray) ||
                    SizeArray != null && other.SizeArray != null &&
                    SizeArray.SequenceEqual(other.SizeArray)
                ) &&
                (
                    SizeSrc == other.SizeSrc ||
                    SizeSrc != null &&
                    SizeSrc.Equals(other.SizeSrc)
                ) && 
                (
                    Solidity == other.Solidity ||
                    Solidity != null &&
                    Solidity.Equals(other.Solidity)
                ) && 
                (
                    Equals(SolidityArray, other.SolidityArray) ||
                    SolidityArray != null && other.SolidityArray != null &&
                    SolidityArray.SequenceEqual(other.SolidityArray)
                ) &&
                (
                    SoliditySrc == other.SoliditySrc ||
                    SoliditySrc != null &&
                    SoliditySrc.Equals(other.SoliditySrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (BgColorArray != null) hashCode = hashCode * 59 + BgColorArray.GetHashCode();
                if (BgColorSrc != null) hashCode = hashCode * 59 + BgColorSrc.GetHashCode();
                if (FgColor != null) hashCode = hashCode * 59 + FgColor.GetHashCode();
                if (FgColorArray != null) hashCode = hashCode * 59 + FgColorArray.GetHashCode();
                if (FgColorSrc != null) hashCode = hashCode * 59 + FgColorSrc.GetHashCode();
                if (FgOpacity != null) hashCode = hashCode * 59 + FgOpacity.GetHashCode();
                if (FillMode != null) hashCode = hashCode * 59 + FillMode.GetHashCode();
                if (Shape != null) hashCode = hashCode * 59 + Shape.GetHashCode();
                if (ShapeArray != null) hashCode = hashCode * 59 + ShapeArray.GetHashCode();
                if (ShapeSrc != null) hashCode = hashCode * 59 + ShapeSrc.GetHashCode();
                if (Size != null) hashCode = hashCode * 59 + Size.GetHashCode();
                if (SizeArray != null) hashCode = hashCode * 59 + SizeArray.GetHashCode();
                if (SizeSrc != null) hashCode = hashCode * 59 + SizeSrc.GetHashCode();
                if (Solidity != null) hashCode = hashCode * 59 + Solidity.GetHashCode();
                if (SolidityArray != null) hashCode = hashCode * 59 + SolidityArray.GetHashCode();
                if (SoliditySrc != null) hashCode = hashCode * 59 + SoliditySrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Pattern and the right Pattern.
        /// </summary>
        /// <param name="left">Left Pattern.</param>
        /// <param name="right">Right Pattern.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Pattern left, Pattern right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Pattern and the right Pattern.
        /// </summary>
        /// <param name="left">Left Pattern.</param>
        /// <param name="right">Right Pattern.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Pattern left, Pattern right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Pattern</returns>
        public Pattern DeepClone()
        {
            return this.Copy();
        }
    }
}