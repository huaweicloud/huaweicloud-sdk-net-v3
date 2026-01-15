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
    public class ShowAuditStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 数据库风险统计
        /// </summary>
        [JsonProperty("db_risk_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseRiskStatisticsDto> DbRiskStatistics { get; set; }

        /// <summary>
        /// 高风险总量
        /// </summary>
        [JsonProperty("high_risk_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? HighRiskTotal { get; set; }

        /// <summary>
        /// 低风险总量
        /// </summary>
        [JsonProperty("low_risk_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? LowRiskTotal { get; set; }

        /// <summary>
        /// 中风险总量
        /// </summary>
        [JsonProperty("medium_risk_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? MediumRiskTotal { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 风险规则统计
        /// </summary>
        [JsonProperty("rule_risk_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleRiskStatisticsDto> RuleRiskStatistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("unsupported_audit_infos", NullValueHandling = NullValueHandling.Ignore)]
        public UnsupportedAuditInfoResponse UnsupportedAuditInfos { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditStatisticsResponse {\n");
            sb.Append("  dbRiskStatistics: ").Append(DbRiskStatistics).Append("\n");
            sb.Append("  highRiskTotal: ").Append(HighRiskTotal).Append("\n");
            sb.Append("  lowRiskTotal: ").Append(LowRiskTotal).Append("\n");
            sb.Append("  mediumRiskTotal: ").Append(MediumRiskTotal).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ruleRiskStatistics: ").Append(RuleRiskStatistics).Append("\n");
            sb.Append("  unsupportedAuditInfos: ").Append(UnsupportedAuditInfos).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.DbRiskStatistics != input.DbRiskStatistics || (this.DbRiskStatistics != null && input.DbRiskStatistics != null && !this.DbRiskStatistics.SequenceEqual(input.DbRiskStatistics))) return false;
            if (this.HighRiskTotal != input.HighRiskTotal || (this.HighRiskTotal != null && !this.HighRiskTotal.Equals(input.HighRiskTotal))) return false;
            if (this.LowRiskTotal != input.LowRiskTotal || (this.LowRiskTotal != null && !this.LowRiskTotal.Equals(input.LowRiskTotal))) return false;
            if (this.MediumRiskTotal != input.MediumRiskTotal || (this.MediumRiskTotal != null && !this.MediumRiskTotal.Equals(input.MediumRiskTotal))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.RuleRiskStatistics != input.RuleRiskStatistics || (this.RuleRiskStatistics != null && input.RuleRiskStatistics != null && !this.RuleRiskStatistics.SequenceEqual(input.RuleRiskStatistics))) return false;
            if (this.UnsupportedAuditInfos != input.UnsupportedAuditInfos || (this.UnsupportedAuditInfos != null && !this.UnsupportedAuditInfos.Equals(input.UnsupportedAuditInfos))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.DbRiskStatistics != null) hashCode = hashCode * 59 + this.DbRiskStatistics.GetHashCode();
                if (this.HighRiskTotal != null) hashCode = hashCode * 59 + this.HighRiskTotal.GetHashCode();
                if (this.LowRiskTotal != null) hashCode = hashCode * 59 + this.LowRiskTotal.GetHashCode();
                if (this.MediumRiskTotal != null) hashCode = hashCode * 59 + this.MediumRiskTotal.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RuleRiskStatistics != null) hashCode = hashCode * 59 + this.RuleRiskStatistics.GetHashCode();
                if (this.UnsupportedAuditInfos != null) hashCode = hashCode * 59 + this.UnsupportedAuditInfos.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
