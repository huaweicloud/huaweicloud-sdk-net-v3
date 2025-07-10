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
    /// Request Object
    /// </summary>
    public class ListScriptTasksRequest 
    {

        /// <summary>
        /// 查询的偏移量，默认值0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 单次查询的大小[1-100]，默认值10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 执行脚本的资源组ID。
        /// </summary>
        [SDKProperty("resource_group_id", IsQuery = true)]
        [JsonProperty("resource_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceGroupId { get; set; }

        /// <summary>
        /// 脚本ID。
        /// </summary>
        [SDKProperty("script_id", IsQuery = true)]
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 脚本名。
        /// </summary>
        [SDKProperty("script_name", IsQuery = true)]
        [JsonProperty("script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptName { get; set; }

        /// <summary>
        /// 执行情况。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 资源组类型。
        /// </summary>
        [SDKProperty("resource_group_type", IsQuery = true)]
        [JsonProperty("resource_group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceGroupType { get; set; }

        /// <summary>
        /// 执行脚本的任务ID。
        /// </summary>
        [SDKProperty("task_id", IsQuery = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskId { get; set; }

        /// <summary>
        /// 任务类型(SCRIPT/COMMAND)。
        /// </summary>
        [SDKProperty("task_type", IsQuery = true)]
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 按执行时间查询的起始时间。指定该参数后，返回的结果为此时间之后的所有任务记录。时间格式如：“2021-10-01T12:00:00Z”。
        /// </summary>
        [SDKProperty("execute_time_start", IsQuery = true)]
        [JsonProperty("execute_time_start", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteTimeStart { get; set; }

        /// <summary>
        /// 按执行时间查询的终止时间。指定该参数后，返回的结果为此时间之前的所有任务记录。时间格式如：“2021-10-01T12:00:00Z”。
        /// </summary>
        [SDKProperty("execute_time_end", IsQuery = true)]
        [JsonProperty("execute_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteTimeEnd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScriptTasksRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  resourceGroupId: ").Append(ResourceGroupId).Append("\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  resourceGroupType: ").Append(ResourceGroupType).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  executeTimeStart: ").Append(ExecuteTimeStart).Append("\n");
            sb.Append("  executeTimeEnd: ").Append(ExecuteTimeEnd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScriptTasksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScriptTasksRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ResourceGroupId != input.ResourceGroupId || (this.ResourceGroupId != null && input.ResourceGroupId != null && !this.ResourceGroupId.SequenceEqual(input.ResourceGroupId))) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && !this.ScriptName.Equals(input.ScriptName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ResourceGroupType != input.ResourceGroupType || (this.ResourceGroupType != null && !this.ResourceGroupType.Equals(input.ResourceGroupType))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && input.TaskId != null && !this.TaskId.SequenceEqual(input.TaskId))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.ExecuteTimeStart != input.ExecuteTimeStart || (this.ExecuteTimeStart != null && !this.ExecuteTimeStart.Equals(input.ExecuteTimeStart))) return false;
            if (this.ExecuteTimeEnd != input.ExecuteTimeEnd || (this.ExecuteTimeEnd != null && !this.ExecuteTimeEnd.Equals(input.ExecuteTimeEnd))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ResourceGroupId != null) hashCode = hashCode * 59 + this.ResourceGroupId.GetHashCode();
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ResourceGroupType != null) hashCode = hashCode * 59 + this.ResourceGroupType.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.ExecuteTimeStart != null) hashCode = hashCode * 59 + this.ExecuteTimeStart.GetHashCode();
                if (this.ExecuteTimeEnd != null) hashCode = hashCode * 59 + this.ExecuteTimeEnd.GetHashCode();
                return hashCode;
            }
        }
    }
}
