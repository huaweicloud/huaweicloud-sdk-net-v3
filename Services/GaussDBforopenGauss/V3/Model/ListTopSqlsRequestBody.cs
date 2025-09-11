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
    /// 
    /// </summary>
    public class ListTopSqlsRequestBody 
    {

        /// <summary>
        /// **参数解释**: 实例ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**: 所选实例节点ID列表。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("node_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// **参数解释**: 起始时间。 **约束限制**: 13位UNIX时间戳格式，单位是毫秒，时区是UTC。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**: 结束时间。 **约束限制**: 13位UNIX时间戳格式，单位是毫秒，时区是UTC。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**: 起始时间。 **约束限制**: UTC时间。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("start_time_utc", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTimeUtc { get; set; }

        /// <summary>
        /// **参数解释**: 结束时间。 **约束限制**: UTC时间。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("end_time_utc", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTimeUtc { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的用户名。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的SQL文本，例如 select pg_sleep(5)。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("sql_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlText { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的归一化SQL ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: Top SQL的数据库名。 **约束限制**: 引擎版本8.200及以上显示。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**: 是否支持展示系统用户。 **约束限制**: 不涉及。 **取值范围**: - true：支持展示系统用户。 - false：不支持展示系统用户。  **默认取值**: 不涉及
        /// </summary>
        [JsonProperty("support_system", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportSystem { get; set; }

        /// <summary>
        /// **参数解释**: 字段汇聚查询条件列表。 **约束限制**: 只支持针对query字段全与或者全或的查询。
        /// </summary>
        [JsonProperty("multi_queries", NullValueHandling = NullValueHandling.Ignore)]
        public List<MultiQueryConditionOption> MultiQueries { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopSqlsRequestBody {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeIds: ").Append(NodeIds).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  startTimeUtc: ").Append(StartTimeUtc).Append("\n");
            sb.Append("  endTimeUtc: ").Append(EndTimeUtc).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  sqlText: ").Append(SqlText).Append("\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  supportSystem: ").Append(SupportSystem).Append("\n");
            sb.Append("  multiQueries: ").Append(MultiQueries).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopSqlsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopSqlsRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.NodeIds != input.NodeIds || (this.NodeIds != null && input.NodeIds != null && !this.NodeIds.SequenceEqual(input.NodeIds))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.StartTimeUtc != input.StartTimeUtc || (this.StartTimeUtc != null && !this.StartTimeUtc.Equals(input.StartTimeUtc))) return false;
            if (this.EndTimeUtc != input.EndTimeUtc || (this.EndTimeUtc != null && !this.EndTimeUtc.Equals(input.EndTimeUtc))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.SqlText != input.SqlText || (this.SqlText != null && !this.SqlText.Equals(input.SqlText))) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SupportSystem != input.SupportSystem || (this.SupportSystem != null && !this.SupportSystem.Equals(input.SupportSystem))) return false;
            if (this.MultiQueries != input.MultiQueries || (this.MultiQueries != null && input.MultiQueries != null && !this.MultiQueries.SequenceEqual(input.MultiQueries))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeIds != null) hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTimeUtc != null) hashCode = hashCode * 59 + this.StartTimeUtc.GetHashCode();
                if (this.EndTimeUtc != null) hashCode = hashCode * 59 + this.EndTimeUtc.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.SqlText != null) hashCode = hashCode * 59 + this.SqlText.GetHashCode();
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SupportSystem != null) hashCode = hashCode * 59 + this.SupportSystem.GetHashCode();
                if (this.MultiQueries != null) hashCode = hashCode * 59 + this.MultiQueries.GetHashCode();
                return hashCode;
            }
        }
    }
}
