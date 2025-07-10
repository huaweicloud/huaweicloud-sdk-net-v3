using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 脚本任务信息。
    /// </summary>
    public class ScriptTaskInfo 
    {

        /// <summary>
        /// 脚本任务ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 脚本列表。
        /// </summary>
        [JsonProperty("task_scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScriptTaskInfoTaskScripts> TaskScripts { get; set; }

        /// <summary>
        /// 资源类型，如DESKTOP。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 执行脚本的资源ID列表。
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 灰度批次执行资源ID列表。
        /// </summary>
        [JsonProperty("gray_resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GrayResourceIds { get; set; }

        /// <summary>
        /// task中成功的执行记录数量。
        /// </summary>
        [JsonProperty("success_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessNum { get; set; }

        /// <summary>
        /// task中失败的执行记录数量。
        /// </summary>
        [JsonProperty("failed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedNum { get; set; }

        /// <summary>
        /// task中跳过的执行记录数量。
        /// </summary>
        [JsonProperty("skip_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SkipNum { get; set; }

        /// <summary>
        /// 脚本执行开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 脚本执行结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 任务结果。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScriptTaskInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  taskScripts: ").Append(TaskScripts).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  grayResourceIds: ").Append(GrayResourceIds).Append("\n");
            sb.Append("  successNum: ").Append(SuccessNum).Append("\n");
            sb.Append("  failedNum: ").Append(FailedNum).Append("\n");
            sb.Append("  skipNum: ").Append(SkipNum).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScriptTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScriptTaskInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TaskScripts != input.TaskScripts || (this.TaskScripts != null && input.TaskScripts != null && !this.TaskScripts.SequenceEqual(input.TaskScripts))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;
            if (this.GrayResourceIds != input.GrayResourceIds || (this.GrayResourceIds != null && input.GrayResourceIds != null && !this.GrayResourceIds.SequenceEqual(input.GrayResourceIds))) return false;
            if (this.SuccessNum != input.SuccessNum || (this.SuccessNum != null && !this.SuccessNum.Equals(input.SuccessNum))) return false;
            if (this.FailedNum != input.FailedNum || (this.FailedNum != null && !this.FailedNum.Equals(input.FailedNum))) return false;
            if (this.SkipNum != input.SkipNum || (this.SkipNum != null && !this.SkipNum.Equals(input.SkipNum))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.TaskScripts != null) hashCode = hashCode * 59 + this.TaskScripts.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                if (this.GrayResourceIds != null) hashCode = hashCode * 59 + this.GrayResourceIds.GetHashCode();
                if (this.SuccessNum != null) hashCode = hashCode * 59 + this.SuccessNum.GetHashCode();
                if (this.FailedNum != null) hashCode = hashCode * 59 + this.FailedNum.GetHashCode();
                if (this.SkipNum != null) hashCode = hashCode * 59 + this.SkipNum.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
