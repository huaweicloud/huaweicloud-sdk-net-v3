using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceTaskResponse : SdkResponse
    {

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数说明**：实例任务类型。 **取值范围**： - CREATE：创建实例任务 - MODIFY：实例规格变更任务 - DELETE：实例删除任务 - FREEZE：实例冻结任务 - UNFREEZE：实例解冻任务 - UPDATE_ACCESS_CONFIG：修改实例接入信息任务 - UPDATE_ALLOW_LISTS： 修改实例接入白名单任务 - OPEN_SNAT：启用实例SNAT配置任务 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数说明**：任务状态。 **取值范围**： - PENDING：等待执行 - RUNNING：执行中 - SUCCESS：执行成功 - FAILED：执行失败 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数说明**：任务状态描述。 
        /// </summary>
        [JsonProperty("status_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// **参数说明**：实例任务的创建时间。格式为：\&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;\&quot; 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数说明**：实例任务的开始时间。格式为：\&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;\&quot; 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数说明**：实例任务的结束时间。格式为：\&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;\&quot; 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_config", NullValueHandling = NullValueHandling.Ignore)]
        public TargetConfig TargetConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operate_window", NullValueHandling = NullValueHandling.Ignore)]
        public OperateWindow OperateWindow { get; set; }

        /// <summary>
        /// **参数说明**：任务进度\&quot; 
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceTaskResponse {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusDetail: ").Append(StatusDetail).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  targetConfig: ").Append(TargetConfig).Append("\n");
            sb.Append("  operateWindow: ").Append(OperateWindow).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceTaskResponse input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusDetail != input.StatusDetail || (this.StatusDetail != null && !this.StatusDetail.Equals(input.StatusDetail))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.TargetConfig != input.TargetConfig || (this.TargetConfig != null && !this.TargetConfig.Equals(input.TargetConfig))) return false;
            if (this.OperateWindow != input.OperateWindow || (this.OperateWindow != null && !this.OperateWindow.Equals(input.OperateWindow))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDetail != null) hashCode = hashCode * 59 + this.StatusDetail.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.TargetConfig != null) hashCode = hashCode * 59 + this.TargetConfig.GetHashCode();
                if (this.OperateWindow != null) hashCode = hashCode * 59 + this.OperateWindow.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                return hashCode;
            }
        }
    }
}
