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
    /// 
    /// </summary>
    public class AuditSummaryResponseDataList 
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 状态 - 1：success - 2：failure
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 审计时长
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
        /// 保留字1
        /// </summary>
        [JsonProperty("reserve1", NullValueHandling = NullValueHandling.Ignore)]
        public string Reserve1 { get; set; }

        /// <summary>
        /// 保留字2
        /// </summary>
        [JsonProperty("reserve2", NullValueHandling = NullValueHandling.Ignore)]
        public string Reserve2 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditSummaryResponseDataList {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  auditDuration: ").Append(AuditDuration).Append("\n");
            sb.Append("  totalSql: ").Append(TotalSql).Append("\n");
            sb.Append("  totalRisk: ").Append(TotalRisk).Append("\n");
            sb.Append("  todaySql: ").Append(TodaySql).Append("\n");
            sb.Append("  todayRisk: ").Append(TodayRisk).Append("\n");
            sb.Append("  todaySession: ").Append(TodaySession).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  reserve1: ").Append(Reserve1).Append("\n");
            sb.Append("  reserve2: ").Append(Reserve2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditSummaryResponseDataList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditSummaryResponseDataList input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.AuditDuration != input.AuditDuration || (this.AuditDuration != null && !this.AuditDuration.Equals(input.AuditDuration))) return false;
            if (this.TotalSql != input.TotalSql || (this.TotalSql != null && !this.TotalSql.Equals(input.TotalSql))) return false;
            if (this.TotalRisk != input.TotalRisk || (this.TotalRisk != null && !this.TotalRisk.Equals(input.TotalRisk))) return false;
            if (this.TodaySql != input.TodaySql || (this.TodaySql != null && !this.TodaySql.Equals(input.TodaySql))) return false;
            if (this.TodayRisk != input.TodayRisk || (this.TodayRisk != null && !this.TodayRisk.Equals(input.TodayRisk))) return false;
            if (this.TodaySession != input.TodaySession || (this.TodaySession != null && !this.TodaySession.Equals(input.TodaySession))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Reserve1 != input.Reserve1 || (this.Reserve1 != null && !this.Reserve1.Equals(input.Reserve1))) return false;
            if (this.Reserve2 != input.Reserve2 || (this.Reserve2 != null && !this.Reserve2.Equals(input.Reserve2))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.AuditDuration != null) hashCode = hashCode * 59 + this.AuditDuration.GetHashCode();
                if (this.TotalSql != null) hashCode = hashCode * 59 + this.TotalSql.GetHashCode();
                if (this.TotalRisk != null) hashCode = hashCode * 59 + this.TotalRisk.GetHashCode();
                if (this.TodaySql != null) hashCode = hashCode * 59 + this.TodaySql.GetHashCode();
                if (this.TodayRisk != null) hashCode = hashCode * 59 + this.TodayRisk.GetHashCode();
                if (this.TodaySession != null) hashCode = hashCode * 59 + this.TodaySession.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Reserve1 != null) hashCode = hashCode * 59 + this.Reserve1.GetHashCode();
                if (this.Reserve2 != null) hashCode = hashCode * 59 + this.Reserve2.GetHashCode();
                return hashCode;
            }
        }
    }
}
