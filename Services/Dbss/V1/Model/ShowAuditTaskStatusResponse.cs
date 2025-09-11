using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAuditTaskStatusResponse : SdkResponse
    {

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// 业务类型  - audit: 审计  - risk: 风险
        /// </summary>
        [JsonProperty("busi_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusiType { get; set; }

        /// <summary>
        /// 已统计实例数
        /// </summary>
        [JsonProperty("completed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletedNum { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Task任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 查询条件：开始时间
        /// </summary>
        [JsonProperty("query_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueryBeginTime { get; set; }

        /// <summary>
        /// 查询条件：结束时间
        /// </summary>
        [JsonProperty("query_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueryEndTime { get; set; }

        /// <summary>
        /// 任务状态  - 0：已就绪  - 1：运行中  - 2：成功  - 3：失败
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务开关
        /// </summary>
        [JsonProperty("task_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskSwitch { get; set; }

        /// <summary>
        /// 总实例数
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditTaskStatusResponse {\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  busiType: ").Append(BusiType).Append("\n");
            sb.Append("  completedNum: ").Append(CompletedNum).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  queryBeginTime: ").Append(QueryBeginTime).Append("\n");
            sb.Append("  queryEndTime: ").Append(QueryEndTime).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  taskSwitch: ").Append(TaskSwitch).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditTaskStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditTaskStatusResponse input)
        {
            if (input == null) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.BusiType != input.BusiType || (this.BusiType != null && !this.BusiType.Equals(input.BusiType))) return false;
            if (this.CompletedNum != input.CompletedNum || (this.CompletedNum != null && !this.CompletedNum.Equals(input.CompletedNum))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.QueryBeginTime != input.QueryBeginTime || (this.QueryBeginTime != null && !this.QueryBeginTime.Equals(input.QueryBeginTime))) return false;
            if (this.QueryEndTime != input.QueryEndTime || (this.QueryEndTime != null && !this.QueryEndTime.Equals(input.QueryEndTime))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;
            if (this.TaskSwitch != input.TaskSwitch || (this.TaskSwitch != null && !this.TaskSwitch.Equals(input.TaskSwitch))) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;

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
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.BusiType != null) hashCode = hashCode * 59 + this.BusiType.GetHashCode();
                if (this.CompletedNum != null) hashCode = hashCode * 59 + this.CompletedNum.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.QueryBeginTime != null) hashCode = hashCode * 59 + this.QueryBeginTime.GetHashCode();
                if (this.QueryEndTime != null) hashCode = hashCode * 59 + this.QueryEndTime.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.TaskSwitch != null) hashCode = hashCode * 59 + this.TaskSwitch.GetHashCode();
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
