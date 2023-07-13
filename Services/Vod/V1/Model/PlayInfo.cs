using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayInfo 
    {

        /// <summary>
        /// 播放协议类型。  取值如下： - hls - dash - mp4
        /// </summary>
        [JsonProperty("play_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayType { get; set; }

        /// <summary>
        /// 播放URL。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 标记流是否已被加密。  取值如下： - 0：表示未加密。 - 1：表示已被加密。  默认值：0。
        /// </summary>
        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public int? Encrypted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public MetaData MetaData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayInfo {\n");
            sb.Append("  playType: ").Append(PlayType).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlayInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlayInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlayType == input.PlayType ||
                    (this.PlayType != null &&
                    this.PlayType.Equals(input.PlayType))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Encrypted == input.Encrypted ||
                    (this.Encrypted != null &&
                    this.Encrypted.Equals(input.Encrypted))
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
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
                if (this.PlayType != null)
                    hashCode = hashCode * 59 + this.PlayType.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Encrypted != null)
                    hashCode = hashCode * 59 + this.Encrypted.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
