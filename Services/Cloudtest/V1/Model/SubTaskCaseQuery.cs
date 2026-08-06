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
    public class SubTaskCaseQuery 
    {

        /// <summary>
        /// 用例创建者
        /// </summary>
        [JsonProperty("create_user", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 用例结束时间
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("keyWord", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 执行机区域ID
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("more", NullValueHandling = NullValueHandling.Ignore)]
        public bool? More { get; set; }

        /// <summary>
        /// 分页时页码
        /// </summary>
        [JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNum { get; set; }

        /// <summary>
        /// 分页时每页大小
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 告警策略选择失败后重试时有值
        /// </summary>
        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        /// <summary>
        /// cloudTest任务执行结果列表
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Results { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("sortBy", NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// 用例所处的阶段 0：前置， 1：测试用例 2：后置用例
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public int? Stage { get; set; }

        /// <summary>
        /// 用例开始时间
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 子任务ID列表
        /// </summary>
        [JsonProperty("subtask_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubtaskIds { get; set; }

        /// <summary>
        /// 子任务ID
        /// </summary>
        [JsonProperty("subtask_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("suiteType", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuiteType { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务ID列表
        /// </summary>
        [JsonProperty("task_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("taskTypeId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskTypeId { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("test_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestServiceId { get; set; }

        /// <summary>
        /// 用例ID
        /// </summary>
        [JsonProperty("testcase_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubTaskCaseQuery {\n");
            sb.Append("  createUser: ").Append(CreateUser).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  locationId: ").Append(LocationId).Append("\n");
            sb.Append("  more: ").Append(More).Append("\n");
            sb.Append("  pageNum: ").Append(PageNum).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pid: ").Append(Pid).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("  sortBy: ").Append(SortBy).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  subtaskIds: ").Append(SubtaskIds).Append("\n");
            sb.Append("  subtaskId: ").Append(SubtaskId).Append("\n");
            sb.Append("  suiteType: ").Append(SuiteType).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskIds: ").Append(TaskIds).Append("\n");
            sb.Append("  taskTypeId: ").Append(TaskTypeId).Append("\n");
            sb.Append("  testServiceId: ").Append(TestServiceId).Append("\n");
            sb.Append("  testcaseId: ").Append(TestcaseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubTaskCaseQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubTaskCaseQuery input)
        {
            if (input == null) return false;
            if (this.CreateUser != input.CreateUser || (this.CreateUser != null && !this.CreateUser.Equals(input.CreateUser))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.LocationId != input.LocationId || (this.LocationId != null && !this.LocationId.Equals(input.LocationId))) return false;
            if (this.More != input.More || (this.More != null && !this.More.Equals(input.More))) return false;
            if (this.PageNum != input.PageNum || (this.PageNum != null && !this.PageNum.Equals(input.PageNum))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Pid != input.Pid || (this.Pid != null && !this.Pid.Equals(input.Pid))) return false;
            if (this.Results != input.Results || (this.Results != null && input.Results != null && !this.Results.SequenceEqual(input.Results))) return false;
            if (this.SortBy != input.SortBy || (this.SortBy != null && !this.SortBy.Equals(input.SortBy))) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.SubtaskIds != input.SubtaskIds || (this.SubtaskIds != null && input.SubtaskIds != null && !this.SubtaskIds.SequenceEqual(input.SubtaskIds))) return false;
            if (this.SubtaskId != input.SubtaskId || (this.SubtaskId != null && !this.SubtaskId.Equals(input.SubtaskId))) return false;
            if (this.SuiteType != input.SuiteType || (this.SuiteType != null && !this.SuiteType.Equals(input.SuiteType))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskIds != input.TaskIds || (this.TaskIds != null && input.TaskIds != null && !this.TaskIds.SequenceEqual(input.TaskIds))) return false;
            if (this.TaskTypeId != input.TaskTypeId || (this.TaskTypeId != null && !this.TaskTypeId.Equals(input.TaskTypeId))) return false;
            if (this.TestServiceId != input.TestServiceId || (this.TestServiceId != null && !this.TestServiceId.Equals(input.TestServiceId))) return false;
            if (this.TestcaseId != input.TestcaseId || (this.TestcaseId != null && !this.TestcaseId.Equals(input.TestcaseId))) return false;

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
                if (this.CreateUser != null) hashCode = hashCode * 59 + this.CreateUser.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.LocationId != null) hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.More != null) hashCode = hashCode * 59 + this.More.GetHashCode();
                if (this.PageNum != null) hashCode = hashCode * 59 + this.PageNum.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Pid != null) hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.SortBy != null) hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubtaskIds != null) hashCode = hashCode * 59 + this.SubtaskIds.GetHashCode();
                if (this.SubtaskId != null) hashCode = hashCode * 59 + this.SubtaskId.GetHashCode();
                if (this.SuiteType != null) hashCode = hashCode * 59 + this.SuiteType.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskIds != null) hashCode = hashCode * 59 + this.TaskIds.GetHashCode();
                if (this.TaskTypeId != null) hashCode = hashCode * 59 + this.TaskTypeId.GetHashCode();
                if (this.TestServiceId != null) hashCode = hashCode * 59 + this.TestServiceId.GetHashCode();
                if (this.TestcaseId != null) hashCode = hashCode * 59 + this.TestcaseId.GetHashCode();
                return hashCode;
            }
        }
    }
}
