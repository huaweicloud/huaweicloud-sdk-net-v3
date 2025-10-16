using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// **参数解释**: LTS对接配置信息。 **取值范围**: 不涉及。
    /// </summary>
    public class LtsConfigInfoResult 
    {

        /// <summary>
        /// **参数解释**: LTS日志组名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志组ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志组类别。 **取值范围**: 通常为asp_log，标识为智能运维专用日志组。
        /// </summary>
        [JsonProperty("group_log_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupLogType { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志组中数据最大保留天数。 **取值范围**: [1,30]
        /// </summary>
        [JsonProperty("group_ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupTtlInDays { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志流名称。 **取值范围**: 通常为STREAM_APS_FULL_SQL-实例ID。
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志流ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志流类别。 **取值范围**: 通常为full_sql，标识为全量SQL专用日志流。
        /// </summary>
        [JsonProperty("stream_log_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamLogType { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志流中数据最大保留天数。 **取值范围**: [1,30]
        /// </summary>
        [JsonProperty("stream_ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? StreamTtlInDays { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志流结构化配置ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("stream_structure_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamStructureConfigId { get; set; }

        /// <summary>
        /// **参数解释**: LTS日志流索引配置ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("stream_index_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamIndexConfigId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LtsConfigInfoResult {\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  groupLogType: ").Append(GroupLogType).Append("\n");
            sb.Append("  groupTtlInDays: ").Append(GroupTtlInDays).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  streamLogType: ").Append(StreamLogType).Append("\n");
            sb.Append("  streamTtlInDays: ").Append(StreamTtlInDays).Append("\n");
            sb.Append("  streamStructureConfigId: ").Append(StreamStructureConfigId).Append("\n");
            sb.Append("  streamIndexConfigId: ").Append(StreamIndexConfigId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LtsConfigInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LtsConfigInfoResult input)
        {
            if (input == null) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.GroupLogType != input.GroupLogType || (this.GroupLogType != null && !this.GroupLogType.Equals(input.GroupLogType))) return false;
            if (this.GroupTtlInDays != input.GroupTtlInDays || (this.GroupTtlInDays != null && !this.GroupTtlInDays.Equals(input.GroupTtlInDays))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.StreamLogType != input.StreamLogType || (this.StreamLogType != null && !this.StreamLogType.Equals(input.StreamLogType))) return false;
            if (this.StreamTtlInDays != input.StreamTtlInDays || (this.StreamTtlInDays != null && !this.StreamTtlInDays.Equals(input.StreamTtlInDays))) return false;
            if (this.StreamStructureConfigId != input.StreamStructureConfigId || (this.StreamStructureConfigId != null && !this.StreamStructureConfigId.Equals(input.StreamStructureConfigId))) return false;
            if (this.StreamIndexConfigId != input.StreamIndexConfigId || (this.StreamIndexConfigId != null && !this.StreamIndexConfigId.Equals(input.StreamIndexConfigId))) return false;

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
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.GroupLogType != null) hashCode = hashCode * 59 + this.GroupLogType.GetHashCode();
                if (this.GroupTtlInDays != null) hashCode = hashCode * 59 + this.GroupTtlInDays.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.StreamLogType != null) hashCode = hashCode * 59 + this.StreamLogType.GetHashCode();
                if (this.StreamTtlInDays != null) hashCode = hashCode * 59 + this.StreamTtlInDays.GetHashCode();
                if (this.StreamStructureConfigId != null) hashCode = hashCode * 59 + this.StreamStructureConfigId.GetHashCode();
                if (this.StreamIndexConfigId != null) hashCode = hashCode * 59 + this.StreamIndexConfigId.GetHashCode();
                return hashCode;
            }
        }
    }
}
