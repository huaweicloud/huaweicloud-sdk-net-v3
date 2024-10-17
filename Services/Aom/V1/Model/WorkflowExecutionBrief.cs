using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 函数流执行概要信息
    /// </summary>
    public class WorkflowExecutionBrief 
    {

        /// <summary>
        /// 流程定义ID
        /// </summary>
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// 流程执行实例ID
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 流程实例执行状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 流程实例创建时间，格式：UTC时间戳
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// 流程实例结束时间，格式：UTC时间戳
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 流程实例上次更新时间，格式：UTC时间戳
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastUpdateTime { get; set; }

        /// <summary>
        /// 流程实例创建者
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 审批人列表
        /// </summary>
        [JsonProperty("approve_user_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ApproveUserNameList { get; set; }

        /// <summary>
        /// 执行记录
        /// </summary>
        [JsonProperty("execution_result_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExecutionResultList> ExecutionResultList { get; set; }

        /// <summary>
        /// 租户从IAM申请到的projectid，一般为32位字符串。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 执行工作流的修改时间，格式：UTC时间戳
        /// </summary>
        [JsonProperty("workflow_edit_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? WorkflowEditTime { get; set; }

        /// <summary>
        /// 执行快照
        /// </summary>
        [JsonProperty("last_record_id_with_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRecordIdWithSnapshot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowExecutionBrief {\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  approveUserNameList: ").Append(ApproveUserNameList).Append("\n");
            sb.Append("  executionResultList: ").Append(ExecutionResultList).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  workflowEditTime: ").Append(WorkflowEditTime).Append("\n");
            sb.Append("  lastRecordIdWithSnapshot: ").Append(LastRecordIdWithSnapshot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowExecutionBrief);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowExecutionBrief input)
        {
            if (input == null) return false;
            if (this.WorkflowId != input.WorkflowId || (this.WorkflowId != null && !this.WorkflowId.Equals(input.WorkflowId))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.ApproveUserNameList != input.ApproveUserNameList || (this.ApproveUserNameList != null && input.ApproveUserNameList != null && !this.ApproveUserNameList.SequenceEqual(input.ApproveUserNameList))) return false;
            if (this.ExecutionResultList != input.ExecutionResultList || (this.ExecutionResultList != null && input.ExecutionResultList != null && !this.ExecutionResultList.SequenceEqual(input.ExecutionResultList))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.WorkflowEditTime != input.WorkflowEditTime || (this.WorkflowEditTime != null && !this.WorkflowEditTime.Equals(input.WorkflowEditTime))) return false;
            if (this.LastRecordIdWithSnapshot != input.LastRecordIdWithSnapshot || (this.LastRecordIdWithSnapshot != null && !this.LastRecordIdWithSnapshot.Equals(input.LastRecordIdWithSnapshot))) return false;

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
                if (this.WorkflowId != null) hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.ApproveUserNameList != null) hashCode = hashCode * 59 + this.ApproveUserNameList.GetHashCode();
                if (this.ExecutionResultList != null) hashCode = hashCode * 59 + this.ExecutionResultList.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.WorkflowEditTime != null) hashCode = hashCode * 59 + this.WorkflowEditTime.GetHashCode();
                if (this.LastRecordIdWithSnapshot != null) hashCode = hashCode * 59 + this.LastRecordIdWithSnapshot.GetHashCode();
                return hashCode;
            }
        }
    }
}
