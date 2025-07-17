using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 延长会议请求。
    /// </summary>
    public class RestProlongDurReqBody 
    {

        /// <summary>
        /// - 0: 手动延长 - 1: 自动延长（未携带延长时间时，默认每次延长15分钟）
        /// </summary>
        [JsonProperty("auto", NullValueHandling = NullValueHandling.Ignore)]
        public int? Auto { get; set; }

        /// <summary>
        /// 延长时间，单位为分钟。 默认值：15
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestProlongDurReqBody {\n");
            sb.Append("  auto: ").Append(Auto).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestProlongDurReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestProlongDurReqBody input)
        {
            if (input == null) return false;
            if (this.Auto != input.Auto || (this.Auto != null && !this.Auto.Equals(input.Auto))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;

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
                if (this.Auto != null) hashCode = hashCode * 59 + this.Auto.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
