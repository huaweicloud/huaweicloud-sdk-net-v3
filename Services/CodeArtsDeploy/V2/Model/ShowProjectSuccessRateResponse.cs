using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowProjectSuccessRateResponse : SdkResponse
    {

        /// <summary>
        /// 成功率
        /// </summary>
        [JsonProperty("success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string SuccessRate { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 应用部署开始时间范围的左边界（包含），格式yyyy-MM-dd
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 应用部署开始时间范围的右边界（包含），格式yyyy-MM-dd
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// 查询到的应用数
        /// </summary>
        [JsonProperty("task_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskCount { get; set; }

        /// <summary>
        /// 查询到的应用部署记录数
        /// </summary>
        [JsonProperty("record_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordCount { get; set; }

        /// <summary>
        /// 成功的应用部署记录数
        /// </summary>
        [JsonProperty("success_record_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessRecordCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectSuccessRateResponse {\n");
            sb.Append("  successRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  taskCount: ").Append(TaskCount).Append("\n");
            sb.Append("  recordCount: ").Append(RecordCount).Append("\n");
            sb.Append("  successRecordCount: ").Append(SuccessRecordCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectSuccessRateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectSuccessRateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuccessRate == input.SuccessRate ||
                    (this.SuccessRate != null &&
                    this.SuccessRate.Equals(input.SuccessRate))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.TaskCount == input.TaskCount ||
                    (this.TaskCount != null &&
                    this.TaskCount.Equals(input.TaskCount))
                ) && 
                (
                    this.RecordCount == input.RecordCount ||
                    (this.RecordCount != null &&
                    this.RecordCount.Equals(input.RecordCount))
                ) && 
                (
                    this.SuccessRecordCount == input.SuccessRecordCount ||
                    (this.SuccessRecordCount != null &&
                    this.SuccessRecordCount.Equals(input.SuccessRecordCount))
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
                if (this.SuccessRate != null)
                    hashCode = hashCode * 59 + this.SuccessRate.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.TaskCount != null)
                    hashCode = hashCode * 59 + this.TaskCount.GetHashCode();
                if (this.RecordCount != null)
                    hashCode = hashCode * 59 + this.RecordCount.GetHashCode();
                if (this.SuccessRecordCount != null)
                    hashCode = hashCode * 59 + this.SuccessRecordCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
