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
    /// 定时任务详情信息
    /// </summary>
    public class ScheduledTaskV3 
    {

        /// <summary>
        /// **参数解释**：  任务创建时间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**：  数据库类型。  **取值范围**： 目前只支持gaussdb-mysql。
        /// </summary>
        [JsonProperty("datastore_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreType { get; set; }

        /// <summary>
        /// **参数解释**：  任务结束时间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**：  任务绑定的实例ID。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  任务绑定的实例名称。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// **参数解释**：  任务绑定的实例状态。  **取值范围**： - NORMAL：实例正常状态。 - BACKING_UP：实例备份中状态。 - MODIFYING：实例修改中状态。 - REBUILDING：实例重建中状态。 - RESTORING：实例恢复中状态。 - FROZEN：实例已冻结状态。 - FAILED：实例状态异常。 - DELETING：实例删除中状态。 - CREATE_FAILED：实例创建失败状态。
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// **参数解释**：  租户项目ID。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**：  任务使用的数据库代理ID。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("proxy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyId { get; set; }

        /// <summary>
        /// **参数解释**：  任务使用的数据库代理名称。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("proxy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyName { get; set; }

        /// <summary>
        /// **参数解释**：  任务开始时间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**：  任务的目标端配置信息，以键值对形式存储。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("target_config", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> TargetConfig { get; set; }

        /// <summary>
        /// **参数解释**：  任务ID，此参数是任务的唯一标识。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释**：  任务名称。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// **参数解释**：  任务执行顺序。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("task_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskOrder { get; set; }

        /// <summary>
        /// **参数解释**：  任务状态。  **取值范围**： - RUNNING：任务正在执行。 - SUCCESS：任务执行成功。 - FAIL：任务执行失败。 - CANCELED：任务被取消。 - WAITING：任务等待执行。
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledTaskV3 {\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  datastoreType: ").Append(DatastoreType).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  proxyId: ").Append(ProxyId).Append("\n");
            sb.Append("  proxyName: ").Append(ProxyName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  targetConfig: ").Append(TargetConfig).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskOrder: ").Append(TaskOrder).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduledTaskV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduledTaskV3 input)
        {
            if (input == null) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.DatastoreType != input.DatastoreType || (this.DatastoreType != null && !this.DatastoreType.Equals(input.DatastoreType))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.InstanceStatus != input.InstanceStatus || (this.InstanceStatus != null && !this.InstanceStatus.Equals(input.InstanceStatus))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProxyId != input.ProxyId || (this.ProxyId != null && !this.ProxyId.Equals(input.ProxyId))) return false;
            if (this.ProxyName != input.ProxyName || (this.ProxyName != null && !this.ProxyName.Equals(input.ProxyName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.TargetConfig != input.TargetConfig || (this.TargetConfig != null && input.TargetConfig != null && !this.TargetConfig.SequenceEqual(input.TargetConfig))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TaskOrder != input.TaskOrder || (this.TaskOrder != null && !this.TaskOrder.Equals(input.TaskOrder))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;

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
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DatastoreType != null) hashCode = hashCode * 59 + this.DatastoreType.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceStatus != null) hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProxyId != null) hashCode = hashCode * 59 + this.ProxyId.GetHashCode();
                if (this.ProxyName != null) hashCode = hashCode * 59 + this.ProxyName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.TargetConfig != null) hashCode = hashCode * 59 + this.TargetConfig.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskOrder != null) hashCode = hashCode * 59 + this.TaskOrder.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
