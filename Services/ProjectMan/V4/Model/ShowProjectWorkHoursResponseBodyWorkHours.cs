using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowProjectWorkHoursResponseBodyWorkHours 
    {

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 工时日期
        /// </summary>
        [JsonProperty("work_date", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkDate { get; set; }

        /// <summary>
        /// 工时花费
        /// </summary>
        [JsonProperty("work_hours_num", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHoursNum { get; set; }

        /// <summary>
        /// 工时内容
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        /// <summary>
        /// 工时类型
        /// </summary>
        [JsonProperty("work_hours_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHoursTypeName { get; set; }

        /// <summary>
        /// 工作项id
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueId { get; set; }

        /// <summary>
        /// 工作项类型
        /// </summary>
        [JsonProperty("issue_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueType { get; set; }

        /// <summary>
        /// 工作项标题
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 工作项创建时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 工作项结束时间
        /// </summary>
        [JsonProperty("closed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedTime { get; set; }

        /// <summary>
        /// 工时创建时间
        /// </summary>
        [JsonProperty("work_hours_created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHoursCreatedTime { get; set; }

        /// <summary>
        /// 工时更新时间
        /// </summary>
        [JsonProperty("work_hours_updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHoursUpdatedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectWorkHoursResponseBodyWorkHours {\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  workDate: ").Append(WorkDate).Append("\n");
            sb.Append("  workHoursNum: ").Append(WorkHoursNum).Append("\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("  workHoursTypeName: ").Append(WorkHoursTypeName).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  issueType: ").Append(IssueType).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  closedTime: ").Append(ClosedTime).Append("\n");
            sb.Append("  workHoursCreatedTime: ").Append(WorkHoursCreatedTime).Append("\n");
            sb.Append("  workHoursUpdatedTime: ").Append(WorkHoursUpdatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectWorkHoursResponseBodyWorkHours);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectWorkHoursResponseBodyWorkHours input)
        {
            if (input == null) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.WorkDate != input.WorkDate || (this.WorkDate != null && !this.WorkDate.Equals(input.WorkDate))) return false;
            if (this.WorkHoursNum != input.WorkHoursNum || (this.WorkHoursNum != null && !this.WorkHoursNum.Equals(input.WorkHoursNum))) return false;
            if (this.Summary != input.Summary || (this.Summary != null && !this.Summary.Equals(input.Summary))) return false;
            if (this.WorkHoursTypeName != input.WorkHoursTypeName || (this.WorkHoursTypeName != null && !this.WorkHoursTypeName.Equals(input.WorkHoursTypeName))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.IssueType != input.IssueType || (this.IssueType != null && !this.IssueType.Equals(input.IssueType))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.ClosedTime != input.ClosedTime || (this.ClosedTime != null && !this.ClosedTime.Equals(input.ClosedTime))) return false;
            if (this.WorkHoursCreatedTime != input.WorkHoursCreatedTime || (this.WorkHoursCreatedTime != null && !this.WorkHoursCreatedTime.Equals(input.WorkHoursCreatedTime))) return false;
            if (this.WorkHoursUpdatedTime != input.WorkHoursUpdatedTime || (this.WorkHoursUpdatedTime != null && !this.WorkHoursUpdatedTime.Equals(input.WorkHoursUpdatedTime))) return false;

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
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.WorkDate != null) hashCode = hashCode * 59 + this.WorkDate.GetHashCode();
                if (this.WorkHoursNum != null) hashCode = hashCode * 59 + this.WorkHoursNum.GetHashCode();
                if (this.Summary != null) hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.WorkHoursTypeName != null) hashCode = hashCode * 59 + this.WorkHoursTypeName.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.IssueType != null) hashCode = hashCode * 59 + this.IssueType.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ClosedTime != null) hashCode = hashCode * 59 + this.ClosedTime.GetHashCode();
                if (this.WorkHoursCreatedTime != null) hashCode = hashCode * 59 + this.WorkHoursCreatedTime.GetHashCode();
                if (this.WorkHoursUpdatedTime != null) hashCode = hashCode * 59 + this.WorkHoursUpdatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
