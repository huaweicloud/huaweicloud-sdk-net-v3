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
    /// 事件详情
    /// </summary>
    public class ScheduleEventInfo 
    {

        /// <summary>
        /// **参数解释**：  事件ID。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  实例ID。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  实例名称。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// **参数解释**：  数据库类型。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DbType { get; set; }

        /// <summary>
        /// **参数解释**：  事件创建的时间。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// **参数解释**：  事件更新的时间。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**：  事件类型。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：  事件对系统的影响。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
        public string Impact { get; set; }

        /// <summary>
        /// **参数解释**：  事件状态。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  事件发生的原因。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// **参数解释**：  事件的严重级别。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// **参数解释**：  事件执行的时间。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// **参数解释**：  事件最近一次执行的时间。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("latest_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestExecutionTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleEventInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  impact: ").Append(Impact).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  executeTime: ").Append(ExecuteTime).Append("\n");
            sb.Append("  latestExecutionTime: ").Append(LatestExecutionTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleEventInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduleEventInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.DbType != input.DbType || (this.DbType != null && !this.DbType.Equals(input.DbType))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Impact != input.Impact || (this.Impact != null && !this.Impact.Equals(input.Impact))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.ExecuteTime != input.ExecuteTime || (this.ExecuteTime != null && !this.ExecuteTime.Equals(input.ExecuteTime))) return false;
            if (this.LatestExecutionTime != input.LatestExecutionTime || (this.LatestExecutionTime != null && !this.LatestExecutionTime.Equals(input.LatestExecutionTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.DbType != null) hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Impact != null) hashCode = hashCode * 59 + this.Impact.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.ExecuteTime != null) hashCode = hashCode * 59 + this.ExecuteTime.GetHashCode();
                if (this.LatestExecutionTime != null) hashCode = hashCode * 59 + this.LatestExecutionTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
