using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteLogStreamRequest 
    {

        /// <summary>
        /// 租户想删除的日志流所在的日志组的groupid，一般为36位字符串。
        /// </summary>
        [SDKProperty("log_group_id", IsPath = true)]
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 需要删除的日志流ID，获取方式请参见：获取账号ID、项目ID、日志组ID、日志流ID（https://support.huaweicloud.com/api-lts/lts_api_0006.html）。
        /// </summary>
        [SDKProperty("log_stream_id", IsPath = true)]
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteLogStreamRequest {\n");
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
            return this.Equals(input as DeleteLogStreamRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteLogStreamRequest input)
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
