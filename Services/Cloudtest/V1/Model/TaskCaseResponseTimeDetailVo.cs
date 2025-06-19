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
    public class TaskCaseResponseTimeDetailVo 
    {

        /// <summary>
        /// 用例ID
        /// </summary>
        [JsonProperty("case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseId { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseName { get; set; }

        /// <summary>
        /// 用例结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 用例状态
        /// </summary>
        [JsonProperty("error_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorReason { get; set; }

        /// <summary>
        /// 用例响应时间
        /// </summary>
        [JsonProperty("response_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResponseTime { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 用例开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 用例状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 子任务ID
        /// </summary>
        [JsonProperty("sub_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTaskId { get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("tag_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TagId { get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("tag_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TagName { get; set; }

        /// <summary>
        /// 任务和用例关联关系的ID
        /// </summary>
        [JsonProperty("task_case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskCaseId { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务类型，1&#x3D;拨测，2&#x3D;冒烟，4&#x3D;部署测试，5&#x3D;小网拨测
        /// </summary>
        [JsonProperty("task_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskTypeId { get; set; }

        /// <summary>
        /// 测试套类型
        /// </summary>
        [JsonProperty("test_suite_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestSuiteType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskCaseResponseTimeDetailVo {\n");
            sb.Append("  caseId: ").Append(CaseId).Append("\n");
            sb.Append("  caseName: ").Append(CaseName).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  errorReason: ").Append(ErrorReason).Append("\n");
            sb.Append("  responseTime: ").Append(ResponseTime).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  subTaskId: ").Append(SubTaskId).Append("\n");
            sb.Append("  tagId: ").Append(TagId).Append("\n");
            sb.Append("  tagName: ").Append(TagName).Append("\n");
            sb.Append("  taskCaseId: ").Append(TaskCaseId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskTypeId: ").Append(TaskTypeId).Append("\n");
            sb.Append("  testSuiteType: ").Append(TestSuiteType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskCaseResponseTimeDetailVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskCaseResponseTimeDetailVo input)
        {
            if (input == null) return false;
            if (this.CaseId != input.CaseId || (this.CaseId != null && !this.CaseId.Equals(input.CaseId))) return false;
            if (this.CaseName != input.CaseName || (this.CaseName != null && !this.CaseName.Equals(input.CaseName))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ErrorReason != input.ErrorReason || (this.ErrorReason != null && !this.ErrorReason.Equals(input.ErrorReason))) return false;
            if (this.ResponseTime != input.ResponseTime || (this.ResponseTime != null && !this.ResponseTime.Equals(input.ResponseTime))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.ServiceName != input.ServiceName || (this.ServiceName != null && !this.ServiceName.Equals(input.ServiceName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.SubTaskId != input.SubTaskId || (this.SubTaskId != null && !this.SubTaskId.Equals(input.SubTaskId))) return false;
            if (this.TagId != input.TagId || (this.TagId != null && !this.TagId.Equals(input.TagId))) return false;
            if (this.TagName != input.TagName || (this.TagName != null && !this.TagName.Equals(input.TagName))) return false;
            if (this.TaskCaseId != input.TaskCaseId || (this.TaskCaseId != null && !this.TaskCaseId.Equals(input.TaskCaseId))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TaskTypeId != input.TaskTypeId || (this.TaskTypeId != null && !this.TaskTypeId.Equals(input.TaskTypeId))) return false;
            if (this.TestSuiteType != input.TestSuiteType || (this.TestSuiteType != null && !this.TestSuiteType.Equals(input.TestSuiteType))) return false;

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
                if (this.CaseId != null) hashCode = hashCode * 59 + this.CaseId.GetHashCode();
                if (this.CaseName != null) hashCode = hashCode * 59 + this.CaseName.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ErrorReason != null) hashCode = hashCode * 59 + this.ErrorReason.GetHashCode();
                if (this.ResponseTime != null) hashCode = hashCode * 59 + this.ResponseTime.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.ServiceName != null) hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubTaskId != null) hashCode = hashCode * 59 + this.SubTaskId.GetHashCode();
                if (this.TagId != null) hashCode = hashCode * 59 + this.TagId.GetHashCode();
                if (this.TagName != null) hashCode = hashCode * 59 + this.TagName.GetHashCode();
                if (this.TaskCaseId != null) hashCode = hashCode * 59 + this.TaskCaseId.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskTypeId != null) hashCode = hashCode * 59 + this.TaskTypeId.GetHashCode();
                if (this.TestSuiteType != null) hashCode = hashCode * 59 + this.TestSuiteType.GetHashCode();
                return hashCode;
            }
        }
    }
}
