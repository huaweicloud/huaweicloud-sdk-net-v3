using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// LTS转发配置信息
    /// </summary>
    public class LtsForwarding 
    {

        /// <summary>
        /// **参数说明**：用于接收日志的日志组Id，通过调用LTS服务创建日志组接口获取(https://support.huaweicloud.com/api-lts/lts_api_0012.html)。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// **参数说明**：用于接收日志的日志流Id，通过调用LTS服务创建日志流接口获取(https://support.huaweicloud.com/api-lts/lts_api_0016.html)。
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LtsForwarding {\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LtsForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LtsForwarding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.LogStreamId == input.LogStreamId ||
                    (this.LogStreamId != null &&
                    this.LogStreamId.Equals(input.LogStreamId))
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
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogStreamId != null)
                    hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
