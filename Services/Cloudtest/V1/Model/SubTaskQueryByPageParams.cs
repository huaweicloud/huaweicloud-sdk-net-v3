using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SubTaskQueryByPageParams 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("more", NullValueHandling = NullValueHandling.Ignore)]
        public bool? More { get; set; }

        /// <summary>
        /// 未设置发布版本
        /// </summary>
        [JsonProperty("notSetReleaseDev", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotSetReleaseDev { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 父任务id
        /// </summary>
        [JsonProperty("parent_sub_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentSubTaskId { get; set; }

        /// <summary>
        /// 测试计划id
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// -| 发布的版本，空数组：代表所有未设置的； null或者无此字段，搜索所有版本 有内容：搜索所有版本
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReleaseDev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Results { get; set; }

        /// <summary>
        /// 任务执行第一次时间
        /// </summary>
        [JsonProperty("start_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTimeBegin { get; set; }

        /// <summary>
        /// 任务执行最后一次时间
        /// </summary>
        [JsonProperty("start_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTimeEnd { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public int? State { get; set; }

        /// <summary>
        /// 子任务状态列表
        /// </summary>
        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> States { get; set; }

        /// <summary>
        /// 子任务任务id
        /// </summary>
        [JsonProperty("sub_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTaskId { get; set; }

        /// <summary>
        /// 测试套类型
        /// </summary>
        [JsonProperty("suite_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuiteType { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务类型，1&#x3D;拨测，2&#x3D;冒烟
        /// </summary>
        [JsonProperty("task_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskTypeId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("test_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestServiceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubTaskQueryByPageParams {\n");
            sb.Append("  more: ").Append(More).Append("\n");
            sb.Append("  notSetReleaseDev: ").Append(NotSetReleaseDev).Append("\n");
            sb.Append("  pageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  parentSubTaskId: ").Append(ParentSubTaskId).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("  startTimeBegin: ").Append(StartTimeBegin).Append("\n");
            sb.Append("  startTimeEnd: ").Append(StartTimeEnd).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  states: ").Append(States).Append("\n");
            sb.Append("  subTaskId: ").Append(SubTaskId).Append("\n");
            sb.Append("  suiteType: ").Append(SuiteType).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskTypeId: ").Append(TaskTypeId).Append("\n");
            sb.Append("  testServiceId: ").Append(TestServiceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubTaskQueryByPageParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubTaskQueryByPageParams input)
        {
            if (input == null) return false;
            if (this.More != input.More || (this.More != null && !this.More.Equals(input.More))) return false;
            if (this.NotSetReleaseDev != input.NotSetReleaseDev || (this.NotSetReleaseDev != null && !this.NotSetReleaseDev.Equals(input.NotSetReleaseDev))) return false;
            if (this.PageNumber != input.PageNumber || (this.PageNumber != null && !this.PageNumber.Equals(input.PageNumber))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.ParentSubTaskId != input.ParentSubTaskId || (this.ParentSubTaskId != null && !this.ParentSubTaskId.Equals(input.ParentSubTaskId))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && input.ReleaseDev != null && !this.ReleaseDev.SequenceEqual(input.ReleaseDev))) return false;
            if (this.Results != input.Results || (this.Results != null && input.Results != null && !this.Results.SequenceEqual(input.Results))) return false;
            if (this.StartTimeBegin != input.StartTimeBegin || (this.StartTimeBegin != null && !this.StartTimeBegin.Equals(input.StartTimeBegin))) return false;
            if (this.StartTimeEnd != input.StartTimeEnd || (this.StartTimeEnd != null && !this.StartTimeEnd.Equals(input.StartTimeEnd))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.States != input.States || (this.States != null && input.States != null && !this.States.SequenceEqual(input.States))) return false;
            if (this.SubTaskId != input.SubTaskId || (this.SubTaskId != null && !this.SubTaskId.Equals(input.SubTaskId))) return false;
            if (this.SuiteType != input.SuiteType || (this.SuiteType != null && !this.SuiteType.Equals(input.SuiteType))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskTypeId != input.TaskTypeId || (this.TaskTypeId != null && !this.TaskTypeId.Equals(input.TaskTypeId))) return false;
            if (this.TestServiceId != input.TestServiceId || (this.TestServiceId != null && !this.TestServiceId.Equals(input.TestServiceId))) return false;

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
                if (this.More != null) hashCode = hashCode * 59 + this.More.GetHashCode();
                if (this.NotSetReleaseDev != null) hashCode = hashCode * 59 + this.NotSetReleaseDev.GetHashCode();
                if (this.PageNumber != null) hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.ParentSubTaskId != null) hashCode = hashCode * 59 + this.ParentSubTaskId.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.StartTimeBegin != null) hashCode = hashCode * 59 + this.StartTimeBegin.GetHashCode();
                if (this.StartTimeEnd != null) hashCode = hashCode * 59 + this.StartTimeEnd.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.States != null) hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.SubTaskId != null) hashCode = hashCode * 59 + this.SubTaskId.GetHashCode();
                if (this.SuiteType != null) hashCode = hashCode * 59 + this.SuiteType.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskTypeId != null) hashCode = hashCode * 59 + this.TaskTypeId.GetHashCode();
                if (this.TestServiceId != null) hashCode = hashCode * 59 + this.TestServiceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
