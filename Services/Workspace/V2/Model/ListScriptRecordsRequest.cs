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
    public class ListScriptRecordsRequest 
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
        /// 执行脚本的资源ID列表。
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// 执行脚本的资源组ID。
        /// </summary>
        [SDKProperty("resource_group_id", IsQuery = true)]
        [JsonProperty("resource_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceGroupId { get; set; }

        /// <summary>
        /// 执行的脚本ID。
        /// </summary>
        [SDKProperty("script_id", IsQuery = true)]
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScriptId { get; set; }

        /// <summary>
        /// 执行的脚本名称。
        /// </summary>
        [SDKProperty("script_name", IsQuery = true)]
        [JsonProperty("script_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScriptName { get; set; }

        /// <summary>
        /// 执行脚本的执行情况。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 是否首批执行。
        /// </summary>
        [SDKProperty("is_first_order", IsQuery = true)]
        [JsonProperty("is_first_order", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFirstOrder { get; set; }

        /// <summary>
        /// 执行脚本的任务ID。
        /// </summary>
        [SDKProperty("script_task_id", IsQuery = true)]
        [JsonProperty("script_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptTaskId { get; set; }

        /// <summary>
        /// 执行记录的任务类型(SCRIPT/COMMAND)。
        /// </summary>
        [SDKProperty("task_type", IsQuery = true)]
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 是否查询历史记录，默认为false，为true时需要同时传入resource_id与script_id。
        /// </summary>
        [SDKProperty("show_history", IsQuery = true)]
        [JsonProperty("show_history", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowHistory { get; set; }

        /// <summary>
        /// 按执行时间查询的起始时间。指定该参数后，返回的结果为此时间之后的所有执行记录。时间格式如：“2021-10-01T12:00:00Z”。
        /// </summary>
        [SDKProperty("execute_time_start", IsQuery = true)]
        [JsonProperty("execute_time_start", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteTimeStart { get; set; }

        /// <summary>
        /// 按执行时间查询的终止时间。指定该参数后，返回的结果为此时间之前的所有执行记录。时间格式如：“2021-10-01T12:00:00Z”。
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
            sb.Append("class ListScriptRecordsRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceGroupId: ").Append(ResourceGroupId).Append("\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  isFirstOrder: ").Append(IsFirstOrder).Append("\n");
            sb.Append("  scriptTaskId: ").Append(ScriptTaskId).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  showHistory: ").Append(ShowHistory).Append("\n");
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
            return this.Equals(input as ListScriptRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScriptRecordsRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && input.ResourceId != null && !this.ResourceId.SequenceEqual(input.ResourceId))) return false;
            if (this.ResourceGroupId != input.ResourceGroupId || (this.ResourceGroupId != null && input.ResourceGroupId != null && !this.ResourceGroupId.SequenceEqual(input.ResourceGroupId))) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && input.ScriptId != null && !this.ScriptId.SequenceEqual(input.ScriptId))) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && input.ScriptName != null && !this.ScriptName.SequenceEqual(input.ScriptName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.IsFirstOrder != input.IsFirstOrder || (this.IsFirstOrder != null && !this.IsFirstOrder.Equals(input.IsFirstOrder))) return false;
            if (this.ScriptTaskId != input.ScriptTaskId || (this.ScriptTaskId != null && !this.ScriptTaskId.Equals(input.ScriptTaskId))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.ShowHistory != input.ShowHistory || (this.ShowHistory != null && !this.ShowHistory.Equals(input.ShowHistory))) return false;
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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceGroupId != null) hashCode = hashCode * 59 + this.ResourceGroupId.GetHashCode();
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsFirstOrder != null) hashCode = hashCode * 59 + this.IsFirstOrder.GetHashCode();
                if (this.ScriptTaskId != null) hashCode = hashCode * 59 + this.ScriptTaskId.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.ShowHistory != null) hashCode = hashCode * 59 + this.ShowHistory.GetHashCode();
                if (this.ExecuteTimeStart != null) hashCode = hashCode * 59 + this.ExecuteTimeStart.GetHashCode();
                if (this.ExecuteTimeEnd != null) hashCode = hashCode * 59 + this.ExecuteTimeEnd.GetHashCode();
                return hashCode;
            }
        }
    }
}
