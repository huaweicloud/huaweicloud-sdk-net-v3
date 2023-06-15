using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowStreamPortraitRequest 
    {

        /// <summary>
        /// 播放域名。 
        /// </summary>
        [SDKProperty("play_domain", IsQuery = true)]
        [JsonProperty("play_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// 流名。 
        /// </summary>
        [SDKProperty("stream", IsQuery = true)]
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 统计日期，日期格式按照ISO8601表示法，格式：YYYYMMDD，如20200904。可以查询过去31天的数据（不含当天）。 
        /// </summary>
        [SDKProperty("time", IsQuery = true)]
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStreamPortraitRequest {\n");
            sb.Append("  playDomain: ").Append(PlayDomain).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStreamPortraitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStreamPortraitRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlayDomain == input.PlayDomain ||
                    (this.PlayDomain != null &&
                    this.PlayDomain.Equals(input.PlayDomain))
                ) && 
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.PlayDomain != null)
                    hashCode = hashCode * 59 + this.PlayDomain.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
