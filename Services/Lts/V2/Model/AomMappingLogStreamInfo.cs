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
    /// 
    /// </summary>
    public class AomMappingLogStreamInfo 
    {

        /// <summary>
        /// 日志组id
        /// </summary>
        [JsonProperty("target_log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogGroupId { get; set; }

        /// <summary>
        /// 目标日志组名称。
        /// </summary>
        [JsonProperty("target_log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogGroupName { get; set; }

        /// <summary>
        /// 日志流id
        /// </summary>
        [JsonProperty("target_log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogStreamId { get; set; }

        /// <summary>
        /// 目标日志组名称。
        /// </summary>
        [JsonProperty("target_log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogStreamName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AomMappingLogStreamInfo {\n");
            sb.Append("  targetLogGroupId: ").Append(TargetLogGroupId).Append("\n");
            sb.Append("  targetLogGroupName: ").Append(TargetLogGroupName).Append("\n");
            sb.Append("  targetLogStreamId: ").Append(TargetLogStreamId).Append("\n");
            sb.Append("  targetLogStreamName: ").Append(TargetLogStreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AomMappingLogStreamInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AomMappingLogStreamInfo input)
        {
            if (input == null) return false;
            if (this.TargetLogGroupId != input.TargetLogGroupId || (this.TargetLogGroupId != null && !this.TargetLogGroupId.Equals(input.TargetLogGroupId))) return false;
            if (this.TargetLogGroupName != input.TargetLogGroupName || (this.TargetLogGroupName != null && !this.TargetLogGroupName.Equals(input.TargetLogGroupName))) return false;
            if (this.TargetLogStreamId != input.TargetLogStreamId || (this.TargetLogStreamId != null && !this.TargetLogStreamId.Equals(input.TargetLogStreamId))) return false;
            if (this.TargetLogStreamName != input.TargetLogStreamName || (this.TargetLogStreamName != null && !this.TargetLogStreamName.Equals(input.TargetLogStreamName))) return false;

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
                if (this.TargetLogGroupId != null) hashCode = hashCode * 59 + this.TargetLogGroupId.GetHashCode();
                if (this.TargetLogGroupName != null) hashCode = hashCode * 59 + this.TargetLogGroupName.GetHashCode();
                if (this.TargetLogStreamId != null) hashCode = hashCode * 59 + this.TargetLogStreamId.GetHashCode();
                if (this.TargetLogStreamName != null) hashCode = hashCode * 59 + this.TargetLogStreamName.GetHashCode();
                return hashCode;
            }
        }
    }
}
