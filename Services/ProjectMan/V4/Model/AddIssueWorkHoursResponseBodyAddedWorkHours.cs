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
    public class AddIssueWorkHoursResponseBodyAddedWorkHours 
    {

        /// <summary>
        /// 工时id
        /// </summary>
        [JsonProperty("work_hours_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHoursId { get; set; }

        /// <summary>
        /// 工作项id
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("user_nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserNickName { get; set; }

        /// <summary>
        /// 工时日期
        /// </summary>
        [JsonProperty("work_date", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkDate { get; set; }

        /// <summary>
        /// 工时数
        /// </summary>
        [JsonProperty("work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHours { get; set; }

        /// <summary>
        /// 工时类型名称
        /// </summary>
        [JsonProperty("work_hours_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHoursTypeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddIssueWorkHoursResponseBodyAddedWorkHours {\n");
            sb.Append("  workHoursId: ").Append(WorkHoursId).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userNickName: ").Append(UserNickName).Append("\n");
            sb.Append("  workDate: ").Append(WorkDate).Append("\n");
            sb.Append("  workHours: ").Append(WorkHours).Append("\n");
            sb.Append("  workHoursTypeName: ").Append(WorkHoursTypeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddIssueWorkHoursResponseBodyAddedWorkHours);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddIssueWorkHoursResponseBodyAddedWorkHours input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkHoursId == input.WorkHoursId ||
                    (this.WorkHoursId != null &&
                    this.WorkHoursId.Equals(input.WorkHoursId))
                ) && 
                (
                    this.IssueId == input.IssueId ||
                    (this.IssueId != null &&
                    this.IssueId.Equals(input.IssueId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UserNickName == input.UserNickName ||
                    (this.UserNickName != null &&
                    this.UserNickName.Equals(input.UserNickName))
                ) && 
                (
                    this.WorkDate == input.WorkDate ||
                    (this.WorkDate != null &&
                    this.WorkDate.Equals(input.WorkDate))
                ) && 
                (
                    this.WorkHours == input.WorkHours ||
                    (this.WorkHours != null &&
                    this.WorkHours.Equals(input.WorkHours))
                ) && 
                (
                    this.WorkHoursTypeName == input.WorkHoursTypeName ||
                    (this.WorkHoursTypeName != null &&
                    this.WorkHoursTypeName.Equals(input.WorkHoursTypeName))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.WorkHoursId != null)
                    hashCode = hashCode * 59 + this.WorkHoursId.GetHashCode();
                if (this.IssueId != null)
                    hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserNickName != null)
                    hashCode = hashCode * 59 + this.UserNickName.GetHashCode();
                if (this.WorkDate != null)
                    hashCode = hashCode * 59 + this.WorkDate.GetHashCode();
                if (this.WorkHours != null)
                    hashCode = hashCode * 59 + this.WorkHours.GetHashCode();
                if (this.WorkHoursTypeName != null)
                    hashCode = hashCode * 59 + this.WorkHoursTypeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
