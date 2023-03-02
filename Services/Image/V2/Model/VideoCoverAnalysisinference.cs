using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoCoverAnalysisinference 
    {

        /// <summary>
        /// 动态封面帧率分子
        /// </summary>
        [JsonProperty("gif_ratenum", NullValueHandling = NullValueHandling.Ignore)]
        public int? GifRatenum { get; set; }

        /// <summary>
        /// 动态封面帧率分母
        /// </summary>
        [JsonProperty("gif_rateden", NullValueHandling = NullValueHandling.Ignore)]
        public int? GifRateden { get; set; }

        /// <summary>
        /// 动态封面长边长度
        /// </summary>
        [JsonProperty("gif_long_side", NullValueHandling = NullValueHandling.Ignore)]
        public int? GifLongSide { get; set; }

        /// <summary>
        /// 动态封面短边长度
        /// </summary>
        [JsonProperty("gif_short_side", NullValueHandling = NullValueHandling.Ignore)]
        public int? GifShortSide { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoCoverAnalysisinference {\n");
            sb.Append("  gifRatenum: ").Append(GifRatenum).Append("\n");
            sb.Append("  gifRateden: ").Append(GifRateden).Append("\n");
            sb.Append("  gifLongSide: ").Append(GifLongSide).Append("\n");
            sb.Append("  gifShortSide: ").Append(GifShortSide).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoCoverAnalysisinference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoCoverAnalysisinference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GifRatenum == input.GifRatenum ||
                    (this.GifRatenum != null &&
                    this.GifRatenum.Equals(input.GifRatenum))
                ) && 
                (
                    this.GifRateden == input.GifRateden ||
                    (this.GifRateden != null &&
                    this.GifRateden.Equals(input.GifRateden))
                ) && 
                (
                    this.GifLongSide == input.GifLongSide ||
                    (this.GifLongSide != null &&
                    this.GifLongSide.Equals(input.GifLongSide))
                ) && 
                (
                    this.GifShortSide == input.GifShortSide ||
                    (this.GifShortSide != null &&
                    this.GifShortSide.Equals(input.GifShortSide))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.GifRatenum != null)
                    hashCode = hashCode * 59 + this.GifRatenum.GetHashCode();
                if (this.GifRateden != null)
                    hashCode = hashCode * 59 + this.GifRateden.GetHashCode();
                if (this.GifLongSide != null)
                    hashCode = hashCode * 59 + this.GifLongSide.GetHashCode();
                if (this.GifShortSide != null)
                    hashCode = hashCode * 59 + this.GifShortSide.GetHashCode();
                return hashCode;
            }
        }
    }
}
