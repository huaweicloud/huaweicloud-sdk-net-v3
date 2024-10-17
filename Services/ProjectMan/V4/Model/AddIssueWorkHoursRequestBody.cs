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
    public class AddIssueWorkHoursRequestBody 
    {

        /// <summary>
        /// 工时开始日期，年-月-日
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 工时结束日期，年-月-日
        /// </summary>
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DueDate { get; set; }

        /// <summary>
        /// 工时总数（若工时日期范围包含多天，单日工时将设为“工时总数/天数”）
        /// </summary>
        [JsonProperty("work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? WorkHours { get; set; }

        /// <summary>
        /// 工时类型id（项目预设工时类型id及名称对照：21:研发设计，22:后端开发，23:前端开发(Web)，24:前端开发(小程序)，25:前端开发(App)， 26:测试验证，27:缺陷修复，28:UI设计，29:会议，30:公共事务，31:培训，32:研究，33:其它，34:调休请假）
        /// </summary>
        [JsonProperty("work_hours_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkHoursTypeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddIssueWorkHoursRequestBody {\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  dueDate: ").Append(DueDate).Append("\n");
            sb.Append("  workHours: ").Append(WorkHours).Append("\n");
            sb.Append("  workHoursTypeId: ").Append(WorkHoursTypeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddIssueWorkHoursRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddIssueWorkHoursRequestBody input)
        {
            if (input == null) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.DueDate != input.DueDate || (this.DueDate != null && !this.DueDate.Equals(input.DueDate))) return false;
            if (this.WorkHours != input.WorkHours || (this.WorkHours != null && !this.WorkHours.Equals(input.WorkHours))) return false;
            if (this.WorkHoursTypeId != input.WorkHoursTypeId || (this.WorkHoursTypeId != null && !this.WorkHoursTypeId.Equals(input.WorkHoursTypeId))) return false;

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
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.DueDate != null) hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.WorkHours != null) hashCode = hashCode * 59 + this.WorkHours.GetHashCode();
                if (this.WorkHoursTypeId != null) hashCode = hashCode * 59 + this.WorkHoursTypeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
