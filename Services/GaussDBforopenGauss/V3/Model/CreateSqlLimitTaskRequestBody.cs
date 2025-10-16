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
    public class CreateSqlLimitTaskRequestBody 
    {

        /// <summary>
        /// **参数解释**: 限流任务范围，目前支持SQL、SESSION级别范围。 **约束限制**: 不涉及。 **取值范围**: - SQL - SESSION  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("task_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskScope { get; set; }

        /// <summary>
        /// **参数解释**: 任务开始时间，如果该值小于当前时间，会取当前时间的前两分钟。 **约束限制**: 当“task_scope”为SQL时必传。 **取值范围**: 格式必须为yyyy-mm-ddThh:mm:ssZ，当前时间指UTC时间。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**: 任务结束时间。 **约束限制**: 当“task_scope”为SQL时必传。 **取值范围**: 大于任务开始时间，格式必须为yyyy-mm-ddThh:mm:ssZ，当前时间指UTC时间。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**: SQL模板。 **约束限制**: 如果“limit_type”为SQLID，必传。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("sql_model", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlModel { get; set; }

        /// <summary>
        /// **参数解释**: 限流类型。 **约束限制**: 不涉及。 **取值范围**: - 当“task_scope”为SQL时，可选SQL_ID、SQL_TYPE类型。 - 当“task_scope”为SESSION时，可选SESSION_ACTIVE_MAX_COUNT类型。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("limit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitType { get; set; }

        /// <summary>
        /// **参数解释**: 限流类型值。 **约束限制**: 不涉及。 **取值范围**: - 当“limit_type”为SQL_ID类型时，该值为选中模板的sql_id。 - 当“limit_type”为SQL_TYPE类型时，值为SQL类型，目前支持select，update，insert，delete，merge。 - 当“limit_type”为SESSION_ACTIVE_MAX_COUNT类型时，只支持CPU_OR_MEMORY一种值。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("limit_type_value", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitTypeValue { get; set; }

        /// <summary>
        /// **参数解释**: 关键词。 **约束限制**: 当且仅当“limit_type”为SQL_TYPE时，必传。 **取值范围**: 多个关键词以逗号隔开，数量范围为[2，100]个，每个关键词长度范围[2，64]位，关键词不允许包含 \&quot; 或 \\ 或 {} 或 null值以及非首尾的空格符。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("key_words", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWords { get; set; }

        /// <summary>
        /// **参数解释**: 限流任务名。 **约束限制**: 不涉及。 **取值范围**: 只能为英文字母大小写，下划线，数字和$符，最大长度为100个字符。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// **参数解释**: 并发数。 **约束限制**: 不涉及。 **取值范围**: 大于等于零的整数，取值范围[0, 2147483647]。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("parallel_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParallelSize { get; set; }

        /// <summary>
        /// **参数解释**: CPU利用率阈值。 **约束限制**: 如果“limit_type”为SESSION_ACTIVE_MAX_COUNT，必传。不支持和内存利用率阈值同时为0，如果选择只限制CPU、内存中的其中一个，则另一个必须传值0。 **取值范围**: 整数，取值范围[0,100）。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_utilization", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuUtilization { get; set; }

        /// <summary>
        /// **参数解释**: 内存利用率阈值。 **约束限制**: 如果“limit_type”为SESSION_ACTIVE_MAX_COUNT，必传。不支持和CPU利用率阈值同时为0，如果选择只限制CPU、内存中的其中一个，则另一个必须传值0。 **取值范围**: 整数，取值范围[0,100）。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("memory_utilization", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryUtilization { get; set; }

        /// <summary>
        /// **参数解释**: 数据库名称，限流只对指定的数据库生效，多个数据库名称用英文逗号分割。 **约束限制**: 当“limit_type”为SQL_TYPE类型时，databases参数必选。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public string Databases { get; set; }

        /// <summary>
        /// **参数解释**: CN节点信息列表 **约束限制**: 如果“limit_type”为SQL_ID，则“node_infos”必选。
        /// </summary>
        [JsonProperty("node_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateLimitTaskNodeOption> NodeInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSqlLimitTaskRequestBody {\n");
            sb.Append("  taskScope: ").Append(TaskScope).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  sqlModel: ").Append(SqlModel).Append("\n");
            sb.Append("  limitType: ").Append(LimitType).Append("\n");
            sb.Append("  limitTypeValue: ").Append(LimitTypeValue).Append("\n");
            sb.Append("  keyWords: ").Append(KeyWords).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  parallelSize: ").Append(ParallelSize).Append("\n");
            sb.Append("  cpuUtilization: ").Append(CpuUtilization).Append("\n");
            sb.Append("  memoryUtilization: ").Append(MemoryUtilization).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("  nodeInfos: ").Append(NodeInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSqlLimitTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSqlLimitTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.TaskScope != input.TaskScope || (this.TaskScope != null && !this.TaskScope.Equals(input.TaskScope))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.SqlModel != input.SqlModel || (this.SqlModel != null && !this.SqlModel.Equals(input.SqlModel))) return false;
            if (this.LimitType != input.LimitType || (this.LimitType != null && !this.LimitType.Equals(input.LimitType))) return false;
            if (this.LimitTypeValue != input.LimitTypeValue || (this.LimitTypeValue != null && !this.LimitTypeValue.Equals(input.LimitTypeValue))) return false;
            if (this.KeyWords != input.KeyWords || (this.KeyWords != null && !this.KeyWords.Equals(input.KeyWords))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.ParallelSize != input.ParallelSize || (this.ParallelSize != null && !this.ParallelSize.Equals(input.ParallelSize))) return false;
            if (this.CpuUtilization != input.CpuUtilization || (this.CpuUtilization != null && !this.CpuUtilization.Equals(input.CpuUtilization))) return false;
            if (this.MemoryUtilization != input.MemoryUtilization || (this.MemoryUtilization != null && !this.MemoryUtilization.Equals(input.MemoryUtilization))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && !this.Databases.Equals(input.Databases))) return false;
            if (this.NodeInfos != input.NodeInfos || (this.NodeInfos != null && input.NodeInfos != null && !this.NodeInfos.SequenceEqual(input.NodeInfos))) return false;

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
                if (this.TaskScope != null) hashCode = hashCode * 59 + this.TaskScope.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.SqlModel != null) hashCode = hashCode * 59 + this.SqlModel.GetHashCode();
                if (this.LimitType != null) hashCode = hashCode * 59 + this.LimitType.GetHashCode();
                if (this.LimitTypeValue != null) hashCode = hashCode * 59 + this.LimitTypeValue.GetHashCode();
                if (this.KeyWords != null) hashCode = hashCode * 59 + this.KeyWords.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.ParallelSize != null) hashCode = hashCode * 59 + this.ParallelSize.GetHashCode();
                if (this.CpuUtilization != null) hashCode = hashCode * 59 + this.CpuUtilization.GetHashCode();
                if (this.MemoryUtilization != null) hashCode = hashCode * 59 + this.MemoryUtilization.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.NodeInfos != null) hashCode = hashCode * 59 + this.NodeInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
