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
    /// 脚本执行记录信息。
    /// </summary>
    public class ScriptRecordSimpleInfo 
    {

        /// <summary>
        /// 脚本执行记录ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 脚本ID。
        /// </summary>
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 脚本名称。
        /// </summary>
        [JsonProperty("script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptName { get; set; }

        /// <summary>
        /// 脚本执行的任务ID。
        /// </summary>
        [JsonProperty("script_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptTaskId { get; set; }

        /// <summary>
        /// 执行脚本的资源ID，如桌面ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 执行脚本的资源名称，如桌面名称。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源类型，如桌面(DESKTOP)。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

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
        /// 脚本执行状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 执行批次（默认：0，灰度：1，非灰度：2）。
        /// </summary>
        [JsonProperty("execute_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteOrder { get; set; }

        /// <summary>
        /// 命令行内容。
        /// </summary>
        [JsonProperty("command_content", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandContent { get; set; }

        /// <summary>
        /// 命令行类型(POWERSHELL/BAT/SHELL)。
        /// </summary>
        [JsonProperty("command_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandType { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 原因。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScriptRecordSimpleInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  scriptTaskId: ").Append(ScriptTaskId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  executeOrder: ").Append(ExecuteOrder).Append("\n");
            sb.Append("  commandContent: ").Append(CommandContent).Append("\n");
            sb.Append("  commandType: ").Append(CommandType).Append("\n");
            sb.Append("  resultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScriptRecordSimpleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScriptRecordSimpleInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && !this.ScriptName.Equals(input.ScriptName))) return false;
            if (this.ScriptTaskId != input.ScriptTaskId || (this.ScriptTaskId != null && !this.ScriptTaskId.Equals(input.ScriptTaskId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ExecuteOrder != input.ExecuteOrder || (this.ExecuteOrder != null && !this.ExecuteOrder.Equals(input.ExecuteOrder))) return false;
            if (this.CommandContent != input.CommandContent || (this.CommandContent != null && !this.CommandContent.Equals(input.CommandContent))) return false;
            if (this.CommandType != input.CommandType || (this.CommandType != null && !this.CommandType.Equals(input.CommandType))) return false;
            if (this.ResultCode != input.ResultCode || (this.ResultCode != null && !this.ResultCode.Equals(input.ResultCode))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;

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
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.ScriptTaskId != null) hashCode = hashCode * 59 + this.ScriptTaskId.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExecuteOrder != null) hashCode = hashCode * 59 + this.ExecuteOrder.GetHashCode();
                if (this.CommandContent != null) hashCode = hashCode * 59 + this.CommandContent.GetHashCode();
                if (this.CommandType != null) hashCode = hashCode * 59 + this.CommandType.GetHashCode();
                if (this.ResultCode != null) hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                return hashCode;
            }
        }
    }
}
