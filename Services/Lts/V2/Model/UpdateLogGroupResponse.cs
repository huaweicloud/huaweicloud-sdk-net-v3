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
    /// Response Object
    /// </summary>
    public class UpdateLogGroupResponse : SdkResponse
    {

        /// <summary>
        /// 创建该日志组的时间， 毫秒级。
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// 日志组的名称。
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 日志组ID。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志存储时间（天）。
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TtlInDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLogGroupResponse {\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLogGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLogGroupResponse input)
        {
            if (input == null) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.TtlInDays != input.TtlInDays || (this.TtlInDays != null && !this.TtlInDays.Equals(input.TtlInDays))) return false;

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
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.TtlInDays != null) hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
