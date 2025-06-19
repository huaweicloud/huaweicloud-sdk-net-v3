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
    public class BranchVersionInfo 
    {

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 开发分支名称
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 是否为Master分支
        /// </summary>
        [JsonProperty("is_master", NullValueHandling = NullValueHandling.Ignore)]
        public string IsMaster { get; set; }

        /// <summary>
        /// PBI ID
        /// </summary>
        [JsonProperty("pbi_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PbiId { get; set; }

        /// <summary>
        /// PBI信息
        /// </summary>
        [JsonProperty("pbi_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PbiName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// 开始时间戳
        /// </summary>
        [JsonProperty("plan_start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanStartTimestamp { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// 结束时间戳
        /// </summary>
        [JsonProperty("plan_end_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanEndTimestamp { get; set; }

        /// <summary>
        /// 是否同步git库
        /// </summary>
        [JsonProperty("asyn_git", NullValueHandling = NullValueHandling.Ignore)]
        public string AsynGit { get; set; }

        /// <summary>
        /// 项目ID（云龙场景，传入微服务ID）
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 项目名称（云龙场景，传入微服务名）
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchVersionInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  isMaster: ").Append(IsMaster).Append("\n");
            sb.Append("  pbiId: ").Append(PbiId).Append("\n");
            sb.Append("  pbiName: ").Append(PbiName).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  planStartTimestamp: ").Append(PlanStartTimestamp).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  planEndTimestamp: ").Append(PlanEndTimestamp).Append("\n");
            sb.Append("  asynGit: ").Append(AsynGit).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BranchVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BranchVersionInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.IsMaster != input.IsMaster || (this.IsMaster != null && !this.IsMaster.Equals(input.IsMaster))) return false;
            if (this.PbiId != input.PbiId || (this.PbiId != null && !this.PbiId.Equals(input.PbiId))) return false;
            if (this.PbiName != input.PbiName || (this.PbiName != null && !this.PbiName.Equals(input.PbiName))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.PlanStartTimestamp != input.PlanStartTimestamp || (this.PlanStartTimestamp != null && !this.PlanStartTimestamp.Equals(input.PlanStartTimestamp))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.PlanEndTimestamp != input.PlanEndTimestamp || (this.PlanEndTimestamp != null && !this.PlanEndTimestamp.Equals(input.PlanEndTimestamp))) return false;
            if (this.AsynGit != input.AsynGit || (this.AsynGit != null && !this.AsynGit.Equals(input.AsynGit))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IsMaster != null) hashCode = hashCode * 59 + this.IsMaster.GetHashCode();
                if (this.PbiId != null) hashCode = hashCode * 59 + this.PbiId.GetHashCode();
                if (this.PbiName != null) hashCode = hashCode * 59 + this.PbiName.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.PlanStartTimestamp != null) hashCode = hashCode * 59 + this.PlanStartTimestamp.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.PlanEndTimestamp != null) hashCode = hashCode * 59 + this.PlanEndTimestamp.GetHashCode();
                if (this.AsynGit != null) hashCode = hashCode * 59 + this.AsynGit.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                return hashCode;
            }
        }
    }
}
