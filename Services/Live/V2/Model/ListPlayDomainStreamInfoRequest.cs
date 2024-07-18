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
    public class ListPlayDomainStreamInfoRequest 
    {

        /// <summary>
        /// 播放域名列表，最多支持查询10个域名，多个域名以逗号分隔。  如果不传入域名，则查询租户下所有播放域名的流数据。 
        /// </summary>
        [SDKProperty("play_domains", IsQuery = true)]
        [JsonProperty("play_domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PlayDomains { get; set; }

        /// <summary>
        /// 查询数据的时间点，精确到分钟。  日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ，最大查询周期七天。  时间必须为时间粒度整时刻点，如：2024-02-02T08:01:00Z。 
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
            sb.Append("class ListPlayDomainStreamInfoRequest {\n");
            sb.Append("  playDomains: ").Append(PlayDomains).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPlayDomainStreamInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPlayDomainStreamInfoRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlayDomains == input.PlayDomains ||
                    this.PlayDomains != null &&
                    input.PlayDomains != null &&
                    this.PlayDomains.SequenceEqual(input.PlayDomains)
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
                if (this.PlayDomains != null)
                    hashCode = hashCode * 59 + this.PlayDomains.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
