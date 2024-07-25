using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceLtsConfigDetailResp 
    {

        /// <summary>
        /// 日志类型
        /// </summary>
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LogType { get; set; }

        /// <summary>
        /// 日志组id
        /// </summary>
        [JsonProperty("lts_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsGroupId { get; set; }

        /// <summary>
        /// 日志流id
        /// </summary>
        [JsonProperty("lts_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsStreamId { get; set; }

        /// <summary>
        /// 是否开启上传至lts
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceLtsConfigDetailResp {\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  ltsGroupId: ").Append(LtsGroupId).Append("\n");
            sb.Append("  ltsStreamId: ").Append(LtsStreamId).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceLtsConfigDetailResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceLtsConfigDetailResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogType == input.LogType ||
                    (this.LogType != null &&
                    this.LogType.Equals(input.LogType))
                ) && 
                (
                    this.LtsGroupId == input.LtsGroupId ||
                    (this.LtsGroupId != null &&
                    this.LtsGroupId.Equals(input.LtsGroupId))
                ) && 
                (
                    this.LtsStreamId == input.LtsStreamId ||
                    (this.LtsStreamId != null &&
                    this.LtsStreamId.Equals(input.LtsStreamId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.LogType != null)
                    hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.LtsGroupId != null)
                    hashCode = hashCode * 59 + this.LtsGroupId.GetHashCode();
                if (this.LtsStreamId != null)
                    hashCode = hashCode * 59 + this.LtsStreamId.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
