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
    /// 过滤条件
    /// </summary>
    public class ReportFilter 
    {

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("creatorIds", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorIds { get; set; }

        /// <summary>
        /// 所属人
        /// </summary>
        [JsonProperty("ownerIds", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerIds { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [JsonProperty("ranks", NullValueHandling = NullValueHandling.Ignore)]
        public string Ranks { get; set; }

        /// <summary>
        /// releaseId
        /// </summary>
        [JsonProperty("releaseIds", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseIds { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [JsonProperty("moduleIds", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleIds { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public string Results { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("labelIds", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelIds { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否关联需求
        /// </summary>
        [JsonProperty("isAssociateIssue", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAssociateIssue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportFilter {\n");
            sb.Append("  creatorIds: ").Append(CreatorIds).Append("\n");
            sb.Append("  ownerIds: ").Append(OwnerIds).Append("\n");
            sb.Append("  ranks: ").Append(Ranks).Append("\n");
            sb.Append("  releaseIds: ").Append(ReleaseIds).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  moduleIds: ").Append(ModuleIds).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("  labelIds: ").Append(LabelIds).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  isAssociateIssue: ").Append(IsAssociateIssue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReportFilter input)
        {
            if (input == null) return false;
            if (this.CreatorIds != input.CreatorIds || (this.CreatorIds != null && !this.CreatorIds.Equals(input.CreatorIds))) return false;
            if (this.OwnerIds != input.OwnerIds || (this.OwnerIds != null && !this.OwnerIds.Equals(input.OwnerIds))) return false;
            if (this.Ranks != input.Ranks || (this.Ranks != null && !this.Ranks.Equals(input.Ranks))) return false;
            if (this.ReleaseIds != input.ReleaseIds || (this.ReleaseIds != null && !this.ReleaseIds.Equals(input.ReleaseIds))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ModuleIds != input.ModuleIds || (this.ModuleIds != null && !this.ModuleIds.Equals(input.ModuleIds))) return false;
            if (this.Results != input.Results || (this.Results != null && !this.Results.Equals(input.Results))) return false;
            if (this.LabelIds != input.LabelIds || (this.LabelIds != null && !this.LabelIds.Equals(input.LabelIds))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.IsAssociateIssue != input.IsAssociateIssue || (this.IsAssociateIssue != null && !this.IsAssociateIssue.Equals(input.IsAssociateIssue))) return false;

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
                if (this.CreatorIds != null) hashCode = hashCode * 59 + this.CreatorIds.GetHashCode();
                if (this.OwnerIds != null) hashCode = hashCode * 59 + this.OwnerIds.GetHashCode();
                if (this.Ranks != null) hashCode = hashCode * 59 + this.Ranks.GetHashCode();
                if (this.ReleaseIds != null) hashCode = hashCode * 59 + this.ReleaseIds.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ModuleIds != null) hashCode = hashCode * 59 + this.ModuleIds.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.LabelIds != null) hashCode = hashCode * 59 + this.LabelIds.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.IsAssociateIssue != null) hashCode = hashCode * 59 + this.IsAssociateIssue.GetHashCode();
                return hashCode;
            }
        }
    }
}
