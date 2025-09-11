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
    public class DatabaseRiskStatisticsDto 
    {

        /// <summary>
        /// 数据库ID
        /// </summary>
        [JsonProperty("db_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbId { get; set; }

        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("db_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIp { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 高风险总量
        /// </summary>
        [JsonProperty("high_risk", NullValueHandling = NullValueHandling.Ignore)]
        public long? HighRisk { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 低风险总量
        /// </summary>
        [JsonProperty("low_risk", NullValueHandling = NullValueHandling.Ignore)]
        public long? LowRisk { get; set; }

        /// <summary>
        /// 中风险总量
        /// </summary>
        [JsonProperty("medium_risk", NullValueHandling = NullValueHandling.Ignore)]
        public long? MediumRisk { get; set; }

        /// <summary>
        /// 风险规则统计
        /// </summary>
        [JsonProperty("risk_rule", NullValueHandling = NullValueHandling.Ignore)]
        public List<RiskRuleStatistic> RiskRule { get; set; }

        /// <summary>
        /// 总风险数量
        /// </summary>
        [JsonProperty("total_risk", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRisk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseRiskStatisticsDto {\n");
            sb.Append("  dbId: ").Append(DbId).Append("\n");
            sb.Append("  dbIp: ").Append(DbIp).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  highRisk: ").Append(HighRisk).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  lowRisk: ").Append(LowRisk).Append("\n");
            sb.Append("  mediumRisk: ").Append(MediumRisk).Append("\n");
            sb.Append("  riskRule: ").Append(RiskRule).Append("\n");
            sb.Append("  totalRisk: ").Append(TotalRisk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseRiskStatisticsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseRiskStatisticsDto input)
        {
            if (input == null) return false;
            if (this.DbId != input.DbId || (this.DbId != null && !this.DbId.Equals(input.DbId))) return false;
            if (this.DbIp != input.DbIp || (this.DbIp != null && !this.DbIp.Equals(input.DbIp))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.HighRisk != input.HighRisk || (this.HighRisk != null && !this.HighRisk.Equals(input.HighRisk))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.LowRisk != input.LowRisk || (this.LowRisk != null && !this.LowRisk.Equals(input.LowRisk))) return false;
            if (this.MediumRisk != input.MediumRisk || (this.MediumRisk != null && !this.MediumRisk.Equals(input.MediumRisk))) return false;
            if (this.RiskRule != input.RiskRule || (this.RiskRule != null && input.RiskRule != null && !this.RiskRule.SequenceEqual(input.RiskRule))) return false;
            if (this.TotalRisk != input.TotalRisk || (this.TotalRisk != null && !this.TotalRisk.Equals(input.TotalRisk))) return false;

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
                if (this.DbId != null) hashCode = hashCode * 59 + this.DbId.GetHashCode();
                if (this.DbIp != null) hashCode = hashCode * 59 + this.DbIp.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.HighRisk != null) hashCode = hashCode * 59 + this.HighRisk.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.LowRisk != null) hashCode = hashCode * 59 + this.LowRisk.GetHashCode();
                if (this.MediumRisk != null) hashCode = hashCode * 59 + this.MediumRisk.GetHashCode();
                if (this.RiskRule != null) hashCode = hashCode * 59 + this.RiskRule.GetHashCode();
                if (this.TotalRisk != null) hashCode = hashCode * 59 + this.TotalRisk.GetHashCode();
                return hashCode;
            }
        }
    }
}
