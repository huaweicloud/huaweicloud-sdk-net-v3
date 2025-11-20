using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAlarmConfigResponse : SdkResponse
    {

        /// <summary>
        /// 0开启 1关闭
        /// </summary>
        [JsonProperty("blackhole", NullValueHandling = NullValueHandling.Ignore)]
        public string Blackhole { get; set; }

        /// <summary>
        /// 0开启 1关闭
        /// </summary>
        [JsonProperty("ddos", NullValueHandling = NullValueHandling.Ignore)]
        public string Ddos { get; set; }

        /// <summary>
        /// topic名称
        /// </summary>
        [JsonProperty("topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicName { get; set; }

        /// <summary>
        /// topic订阅链接
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAlarmConfigResponse {\n");
            sb.Append("  blackhole: ").Append(Blackhole).Append("\n");
            sb.Append("  ddos: ").Append(Ddos).Append("\n");
            sb.Append("  topicName: ").Append(TopicName).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAlarmConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAlarmConfigResponse input)
        {
            if (input == null) return false;
            if (this.Blackhole != input.Blackhole || (this.Blackhole != null && !this.Blackhole.Equals(input.Blackhole))) return false;
            if (this.Ddos != input.Ddos || (this.Ddos != null && !this.Ddos.Equals(input.Ddos))) return false;
            if (this.TopicName != input.TopicName || (this.TopicName != null && !this.TopicName.Equals(input.TopicName))) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Blackhole != null) hashCode = hashCode * 59 + this.Blackhole.GetHashCode();
                if (this.Ddos != null) hashCode = hashCode * 59 + this.Ddos.GetHashCode();
                if (this.TopicName != null) hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
