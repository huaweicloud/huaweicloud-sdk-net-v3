using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageDetectionResultDetail 
    {

        /// <summary>
        /// 涉政敏感人物检测结果。
        /// </summary>
        [JsonProperty("politics", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageDetectionResultDetailPolitics> Politics { get; set; }

        /// <summary>
        /// 涉黄检测结果。
        /// </summary>
        [JsonProperty("porn", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageDetectionResultSimpleDetail> Porn { get; set; }

        /// <summary>
        /// 涉政、暴恐检测结果。
        /// </summary>
        [JsonProperty("terrorism", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageDetectionResultSimpleDetail> Terrorism { get; set; }

        /// <summary>
        /// 广告检测结果。
        /// </summary>
        [JsonProperty("ad", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageDetectionResultAdDetail> Ad { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionResultDetail {\n");
            sb.Append("  politics: ").Append(Politics).Append("\n");
            sb.Append("  porn: ").Append(Porn).Append("\n");
            sb.Append("  terrorism: ").Append(Terrorism).Append("\n");
            sb.Append("  ad: ").Append(Ad).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionResultDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionResultDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Politics == input.Politics ||
                    this.Politics != null &&
                    input.Politics != null &&
                    this.Politics.SequenceEqual(input.Politics)
                ) && 
                (
                    this.Porn == input.Porn ||
                    this.Porn != null &&
                    input.Porn != null &&
                    this.Porn.SequenceEqual(input.Porn)
                ) && 
                (
                    this.Terrorism == input.Terrorism ||
                    this.Terrorism != null &&
                    input.Terrorism != null &&
                    this.Terrorism.SequenceEqual(input.Terrorism)
                ) && 
                (
                    this.Ad == input.Ad ||
                    this.Ad != null &&
                    input.Ad != null &&
                    this.Ad.SequenceEqual(input.Ad)
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
                if (this.Politics != null)
                    hashCode = hashCode * 59 + this.Politics.GetHashCode();
                if (this.Porn != null)
                    hashCode = hashCode * 59 + this.Porn.GetHashCode();
                if (this.Terrorism != null)
                    hashCode = hashCode * 59 + this.Terrorism.GetHashCode();
                if (this.Ad != null)
                    hashCode = hashCode * 59 + this.Ad.GetHashCode();
                return hashCode;
            }
        }
    }
}
