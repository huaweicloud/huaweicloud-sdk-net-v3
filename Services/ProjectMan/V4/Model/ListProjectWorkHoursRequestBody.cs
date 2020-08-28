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
    public class ListProjectWorkHoursRequestBody 
    {

        /// <summary>
        /// 查询的项目id列表
        /// </summary>
        [JsonProperty("project_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProjectIds { get; set; }

        /// <summary>
        /// 查询的用户id列表
        /// </summary>
        [JsonProperty("user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// 工时类型，以逗号分隔,21:研发设计,22:后端开发,23:前端开发(Web),24:前端开发(小程序),25:前端开发(App),26:测试验证,27:缺陷修复,28:UI设计,29:会议,30:公共事务,31:培训,32:研究,33:其它,34:调休请假
        /// </summary>
        [JsonProperty("work_hours_types", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHoursTypes { get; set; }

        /// <summary>
        /// 工时日期，以逗号分隔，年-月-日
        /// </summary>
        [JsonProperty("work_hours_dates", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkHoursDates { get; set; }

        /// <summary>
        /// 工时开始日期，年-月-日
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 工时结束日期，年-月-日
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 每页显示数量，每页最多显示100条
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectWorkHoursRequestBody {\n");
            sb.Append("  projectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  userIds: ").Append(UserIds).Append("\n");
            sb.Append("  workHoursTypes: ").Append(WorkHoursTypes).Append("\n");
            sb.Append("  workHoursDates: ").Append(WorkHoursDates).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectWorkHoursRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectWorkHoursRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    input.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
                ) && 
                (
                    this.WorkHoursTypes == input.WorkHoursTypes ||
                    (this.WorkHoursTypes != null &&
                    this.WorkHoursTypes.Equals(input.WorkHoursTypes))
                ) && 
                (
                    this.WorkHoursDates == input.WorkHoursDates ||
                    (this.WorkHoursDates != null &&
                    this.WorkHoursDates.Equals(input.WorkHoursDates))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.ProjectIds != null)
                    hashCode = hashCode * 59 + this.ProjectIds.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                if (this.WorkHoursTypes != null)
                    hashCode = hashCode * 59 + this.WorkHoursTypes.GetHashCode();
                if (this.WorkHoursDates != null)
                    hashCode = hashCode * 59 + this.WorkHoursDates.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
