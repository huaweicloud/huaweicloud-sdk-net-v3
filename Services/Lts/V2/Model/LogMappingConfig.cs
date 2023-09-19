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
    public class LogMappingConfig 
    {

        /// <summary>
        /// 源日志组ID
        /// </summary>
        [JsonProperty("source_log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceLogGroupId { get; set; }

        /// <summary>
        /// 目标日志组ID
        /// </summary>
        [JsonProperty("target_log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogGroupId { get; set; }

        /// <summary>
        /// 目标日志组名称
        /// </summary>
        [JsonProperty("target_log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogGroupName { get; set; }

        /// <summary>
        /// 日志流配置
        /// </summary>
        [JsonProperty("log_stream_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogMappingStreamInfo> LogStreamConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogMappingConfig {\n");
            sb.Append("  sourceLogGroupId: ").Append(SourceLogGroupId).Append("\n");
            sb.Append("  targetLogGroupId: ").Append(TargetLogGroupId).Append("\n");
            sb.Append("  targetLogGroupName: ").Append(TargetLogGroupName).Append("\n");
            sb.Append("  logStreamConfig: ").Append(LogStreamConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogMappingConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogMappingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceLogGroupId == input.SourceLogGroupId ||
                    (this.SourceLogGroupId != null &&
                    this.SourceLogGroupId.Equals(input.SourceLogGroupId))
                ) && 
                (
                    this.TargetLogGroupId == input.TargetLogGroupId ||
                    (this.TargetLogGroupId != null &&
                    this.TargetLogGroupId.Equals(input.TargetLogGroupId))
                ) && 
                (
                    this.TargetLogGroupName == input.TargetLogGroupName ||
                    (this.TargetLogGroupName != null &&
                    this.TargetLogGroupName.Equals(input.TargetLogGroupName))
                ) && 
                (
                    this.LogStreamConfig == input.LogStreamConfig ||
                    this.LogStreamConfig != null &&
                    input.LogStreamConfig != null &&
                    this.LogStreamConfig.SequenceEqual(input.LogStreamConfig)
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
                if (this.SourceLogGroupId != null)
                    hashCode = hashCode * 59 + this.SourceLogGroupId.GetHashCode();
                if (this.TargetLogGroupId != null)
                    hashCode = hashCode * 59 + this.TargetLogGroupId.GetHashCode();
                if (this.TargetLogGroupName != null)
                    hashCode = hashCode * 59 + this.TargetLogGroupName.GetHashCode();
                if (this.LogStreamConfig != null)
                    hashCode = hashCode * 59 + this.LogStreamConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
