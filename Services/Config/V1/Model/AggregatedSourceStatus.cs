using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 资源聚合器状态响应体。
    /// </summary>
    public class AggregatedSourceStatus 
    {

        /// <summary>
        /// 源帐号最近一次聚合失败时返回的错误码。
        /// </summary>
        [JsonProperty("last_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LastErrorCode { get; set; }

        /// <summary>
        /// 源帐号最近一次聚合失败时返回的错误消息。
        /// </summary>
        [JsonProperty("last_error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string LastErrorMessage { get; set; }

        /// <summary>
        /// 最近一次更新的状态类型。
        /// </summary>
        [JsonProperty("last_update_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateStatus { get; set; }

        /// <summary>
        /// 最近一次更新的时间。
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 源帐号ID或组织。
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 帐号名。
        /// </summary>
        [JsonProperty("source_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceName { get; set; }

        /// <summary>
        /// 源帐号类型（ACCOUNT | ORGANIZATION）。
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatedSourceStatus {\n");
            sb.Append("  lastErrorCode: ").Append(LastErrorCode).Append("\n");
            sb.Append("  lastErrorMessage: ").Append(LastErrorMessage).Append("\n");
            sb.Append("  lastUpdateStatus: ").Append(LastUpdateStatus).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  sourceName: ").Append(SourceName).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AggregatedSourceStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AggregatedSourceStatus input)
        {
            if (input == null) return false;
            if (this.LastErrorCode != input.LastErrorCode || (this.LastErrorCode != null && !this.LastErrorCode.Equals(input.LastErrorCode))) return false;
            if (this.LastErrorMessage != input.LastErrorMessage || (this.LastErrorMessage != null && !this.LastErrorMessage.Equals(input.LastErrorMessage))) return false;
            if (this.LastUpdateStatus != input.LastUpdateStatus || (this.LastUpdateStatus != null && !this.LastUpdateStatus.Equals(input.LastUpdateStatus))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.SourceName != input.SourceName || (this.SourceName != null && !this.SourceName.Equals(input.SourceName))) return false;
            if (this.SourceType != input.SourceType || (this.SourceType != null && !this.SourceType.Equals(input.SourceType))) return false;

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
                if (this.LastErrorCode != null) hashCode = hashCode * 59 + this.LastErrorCode.GetHashCode();
                if (this.LastErrorMessage != null) hashCode = hashCode * 59 + this.LastErrorMessage.GetHashCode();
                if (this.LastUpdateStatus != null) hashCode = hashCode * 59 + this.LastUpdateStatus.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SourceName != null) hashCode = hashCode * 59 + this.SourceName.GetHashCode();
                if (this.SourceType != null) hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
