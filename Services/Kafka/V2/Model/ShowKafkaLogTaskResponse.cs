using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowKafkaLogTaskResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 日志响应列表。
        /// </summary>
        [JsonProperty("log_response_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowKafkaLogTaskEntity> LogResponseList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKafkaLogTaskResponse {\n");
            sb.Append("  logResponseList: ").Append(LogResponseList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKafkaLogTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKafkaLogTaskResponse input)
        {
            if (input == null) return false;
            if (this.LogResponseList != input.LogResponseList || (this.LogResponseList != null && input.LogResponseList != null && !this.LogResponseList.SequenceEqual(input.LogResponseList))) return false;

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
                if (this.LogResponseList != null) hashCode = hashCode * 59 + this.LogResponseList.GetHashCode();
                return hashCode;
            }
        }
    }
}
