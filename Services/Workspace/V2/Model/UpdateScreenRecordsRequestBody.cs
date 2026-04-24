using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 更新录屏审计请求体
    /// </summary>
    public class UpdateScreenRecordsRequestBody 
    {

        /// <summary>
        /// 录屏限速类型
        /// </summary>
        [JsonProperty("traffic_limit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficLimitType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateScreenRecordsRequestBody {\n");
            sb.Append("  trafficLimitType: ").Append(TrafficLimitType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateScreenRecordsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateScreenRecordsRequestBody input)
        {
            if (input == null) return false;
            if (this.TrafficLimitType != input.TrafficLimitType || (this.TrafficLimitType != null && !this.TrafficLimitType.Equals(input.TrafficLimitType))) return false;

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
                if (this.TrafficLimitType != null) hashCode = hashCode * 59 + this.TrafficLimitType.GetHashCode();
                return hashCode;
            }
        }
    }
}
