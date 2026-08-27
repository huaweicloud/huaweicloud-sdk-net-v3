using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// **参数解释**：  事件详情。  **约束限制**：  不涉及。
    /// </summary>
    public class ScheduleEventInfo 
    {

        /// <summary>
        /// **参数解释**：  事件ID。  **取值范围**：  只能由英文字母、数字组成，前面为UUID，后缀为ev07，长度为36个字符。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  事件类别。  **取值范围**：  Maintenance：计划内运维事件。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**：  事件影响。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
        public string Impact { get; set; }

        /// <summary>
        /// **参数解释**：  事件状态。  **取值范围**：    - inquiring：待授权。   - scheduled：待执行。   - executing：执行中。   - completed：执行完成。   - canceled：事件关闭。   - failed：执行失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  事件原因。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// **参数解释**：  事件级别。  **取值范围**：  - critical：紧急。 - major：重要。 - minor：一般。 - info：提示。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// **参数解释**：  实例ID。  **取值范围**：  只能由英文字母、数字组成，前面为UUID，后缀为in07，长度为36个字符。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  实例名称。  **取值范围**：  最小为4个字符，最大为64个字符且不超过64个字节（注意：一个中文字符占用3个字节），必须以字母或中文开头，区分大小写，可以包含字母、数字、中划线、下划线或中文，不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// **参数解释**：  引擎名称。  **取值范围**：  taurus：TaurusDB企业版。
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DbType { get; set; }

        /// <summary>
        /// **参数解释**：  创建时间。UTC，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// **参数解释**：  更新时间。UTC，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// **参数解释**：  事件类型。  **取值范围**：  - system.lifecycle.rebuild_node：备机重建事件。 - system.lifecycle.db_upgrade：数据库内核小版本升级事件。 - system.scheduled_event.high_cpu_memory：实例CPU或内存高负载事件，需要变更实例规格。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：  扩展信息。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// **参数解释**：  事件的执行时间。UTC，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// **参数解释**：  事件执行窗口。
        /// </summary>
        [JsonProperty("execution_time_window", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExecutionTimeWindow { get; set; }

        /// <summary>
        /// **参数解释**：  事件对象信息列表，包含事件对象ID和事件对象的执行状态
        /// </summary>
        [JsonProperty("event_entities", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventEntity> EventEntities { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleEventInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  impact: ").Append(Impact).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  extendInfo: ").Append(ExtendInfo).Append("\n");
            sb.Append("  executeTime: ").Append(ExecuteTime).Append("\n");
            sb.Append("  executionTimeWindow: ").Append(ExecutionTimeWindow).Append("\n");
            sb.Append("  eventEntities: ").Append(EventEntities).Append("\n");
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
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Impact != input.Impact || (this.Impact != null && !this.Impact.Equals(input.Impact))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.DbType != input.DbType || (this.DbType != null && !this.DbType.Equals(input.DbType))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.UpdatedTime != input.UpdatedTime || (this.UpdatedTime != null && !this.UpdatedTime.Equals(input.UpdatedTime))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ExtendInfo != input.ExtendInfo || (this.ExtendInfo != null && !this.ExtendInfo.Equals(input.ExtendInfo))) return false;
            if (this.ExecuteTime != input.ExecuteTime || (this.ExecuteTime != null && !this.ExecuteTime.Equals(input.ExecuteTime))) return false;
            if (this.ExecutionTimeWindow != input.ExecutionTimeWindow || (this.ExecutionTimeWindow != null && !this.ExecutionTimeWindow.Equals(input.ExecutionTimeWindow))) return false;
            if (this.EventEntities != input.EventEntities || (this.EventEntities != null && input.EventEntities != null && !this.EventEntities.SequenceEqual(input.EventEntities))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Impact != null) hashCode = hashCode * 59 + this.Impact.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.DbType != null) hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.UpdatedTime != null) hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExtendInfo != null) hashCode = hashCode * 59 + this.ExtendInfo.GetHashCode();
                if (this.ExecuteTime != null) hashCode = hashCode * 59 + this.ExecuteTime.GetHashCode();
                if (this.ExecutionTimeWindow != null) hashCode = hashCode * 59 + this.ExecutionTimeWindow.GetHashCode();
                if (this.EventEntities != null) hashCode = hashCode * 59 + this.EventEntities.GetHashCode();
                return hashCode;
            }
        }
    }
}
