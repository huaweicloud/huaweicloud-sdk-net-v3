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
    public class ListAuditSummaryInfosResponse : SdkResponse
    {

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 审计总时长
        /// </summary>
        [JsonProperty("audit_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? AuditDuration { get; set; }

        /// <summary>
        /// 语句总量
        /// </summary>
        [JsonProperty("total_sql", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalSql { get; set; }

        /// <summary>
        /// 风险总量
        /// </summary>
        [JsonProperty("total_risk", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRisk { get; set; }

        /// <summary>
        /// 今日语句
        /// </summary>
        [JsonProperty("today_sql", NullValueHandling = NullValueHandling.Ignore)]
        public long? TodaySql { get; set; }

        /// <summary>
        /// 今日风险
        /// </summary>
        [JsonProperty("today_risk", NullValueHandling = NullValueHandling.Ignore)]
        public long? TodayRisk { get; set; }

        /// <summary>
        /// 今日会话
        /// </summary>
        [JsonProperty("today_session", NullValueHandling = NullValueHandling.Ignore)]
        public long? TodaySession { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 列表信息
        /// </summary>
        [JsonProperty("data_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditSummaryResponseDataList> DataList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditSummaryInfosResponse {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  auditDuration: ").Append(AuditDuration).Append("\n");
            sb.Append("  totalSql: ").Append(TotalSql).Append("\n");
            sb.Append("  totalRisk: ").Append(TotalRisk).Append("\n");
            sb.Append("  todaySql: ").Append(TodaySql).Append("\n");
            sb.Append("  todayRisk: ").Append(TodayRisk).Append("\n");
            sb.Append("  todaySession: ").Append(TodaySession).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  dataList: ").Append(DataList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuditSummaryInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuditSummaryInfosResponse input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AuditDuration != input.AuditDuration || (this.AuditDuration != null && !this.AuditDuration.Equals(input.AuditDuration))) return false;
            if (this.TotalSql != input.TotalSql || (this.TotalSql != null && !this.TotalSql.Equals(input.TotalSql))) return false;
            if (this.TotalRisk != input.TotalRisk || (this.TotalRisk != null && !this.TotalRisk.Equals(input.TotalRisk))) return false;
            if (this.TodaySql != input.TodaySql || (this.TodaySql != null && !this.TodaySql.Equals(input.TodaySql))) return false;
            if (this.TodayRisk != input.TodayRisk || (this.TodayRisk != null && !this.TodayRisk.Equals(input.TodayRisk))) return false;
            if (this.TodaySession != input.TodaySession || (this.TodaySession != null && !this.TodaySession.Equals(input.TodaySession))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.DataList != input.DataList || (this.DataList != null && input.DataList != null && !this.DataList.SequenceEqual(input.DataList))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AuditDuration != null) hashCode = hashCode * 59 + this.AuditDuration.GetHashCode();
                if (this.TotalSql != null) hashCode = hashCode * 59 + this.TotalSql.GetHashCode();
                if (this.TotalRisk != null) hashCode = hashCode * 59 + this.TotalRisk.GetHashCode();
                if (this.TodaySql != null) hashCode = hashCode * 59 + this.TodaySql.GetHashCode();
                if (this.TodayRisk != null) hashCode = hashCode * 59 + this.TodayRisk.GetHashCode();
                if (this.TodaySession != null) hashCode = hashCode * 59 + this.TodaySession.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.DataList != null) hashCode = hashCode * 59 + this.DataList.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
